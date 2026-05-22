using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class RelicSmartWearUpdatePinRelicScRsp : IMessage<RelicSmartWearUpdatePinRelicScRsp>, IMessage, IEquatable<RelicSmartWearUpdatePinRelicScRsp>, IDeepCloneable<RelicSmartWearUpdatePinRelicScRsp>, IBufferMessage
{
	private static readonly MessageParser<RelicSmartWearUpdatePinRelicScRsp> _parser = new MessageParser<RelicSmartWearUpdatePinRelicScRsp>(() => new RelicSmartWearUpdatePinRelicScRsp());

	private UnknownFieldSet _unknownFields;

	public const int DACMPJLJGBCFieldNumber = 7;

	private BDEKEIKAKML dACMPJLJGBC_;

	public const int RetcodeFieldNumber = 9;

	private uint retcode_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<RelicSmartWearUpdatePinRelicScRsp> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => RelicSmartWearUpdatePinRelicScRspReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BDEKEIKAKML DACMPJLJGBC
	{
		get
		{
			return dACMPJLJGBC_;
		}
		set
		{
			dACMPJLJGBC_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint Retcode
	{
		get
		{
			return retcode_;
		}
		set
		{
			retcode_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RelicSmartWearUpdatePinRelicScRsp()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RelicSmartWearUpdatePinRelicScRsp(RelicSmartWearUpdatePinRelicScRsp other)
		: this()
	{
		dACMPJLJGBC_ = ((other.dACMPJLJGBC_ != null) ? other.dACMPJLJGBC_.Clone() : null);
		retcode_ = other.retcode_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RelicSmartWearUpdatePinRelicScRsp Clone()
	{
		return new RelicSmartWearUpdatePinRelicScRsp(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as RelicSmartWearUpdatePinRelicScRsp);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(RelicSmartWearUpdatePinRelicScRsp other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(DACMPJLJGBC, other.DACMPJLJGBC))
		{
			return false;
		}
		if (Retcode != other.Retcode)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		int num = 1;
		if (dACMPJLJGBC_ != null)
		{
			num ^= DACMPJLJGBC.GetHashCode();
		}
		if (Retcode != 0)
		{
			num ^= Retcode.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return JsonFormatter.ToDiagnosticString(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
		output.WriteRawMessage(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	void IBufferMessage.InternalWriteTo(ref WriteContext output)
	{
		if (dACMPJLJGBC_ != null)
		{
			output.WriteRawTag(58);
			output.WriteMessage(DACMPJLJGBC);
		}
		if (Retcode != 0)
		{
			output.WriteRawTag(72);
			output.WriteUInt32(Retcode);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(ref output);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		int num = 0;
		if (dACMPJLJGBC_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(DACMPJLJGBC);
		}
		if (Retcode != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Retcode);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(RelicSmartWearUpdatePinRelicScRsp other)
	{
		if (other == null)
		{
			return;
		}
		if (other.dACMPJLJGBC_ != null)
		{
			if (dACMPJLJGBC_ == null)
			{
				DACMPJLJGBC = new BDEKEIKAKML();
			}
			DACMPJLJGBC.MergeFrom(other.DACMPJLJGBC);
		}
		if (other.Retcode != 0)
		{
			Retcode = other.Retcode;
		}
		_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
		input.ReadRawMessage(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	void IBufferMessage.InternalMergeFrom(ref ParseContext input)
	{
		uint num;
		while ((num = input.ReadTag()) != 0 && (num & 7) != 4)
		{
			switch (num)
			{
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			case 58u:
				if (dACMPJLJGBC_ == null)
				{
					DACMPJLJGBC = new BDEKEIKAKML();
				}
				input.ReadMessage(DACMPJLJGBC);
				break;
			case 72u:
				Retcode = input.ReadUInt32();
				break;
			}
		}
	}
}
