using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class TrainPartyUseCardScRsp : IMessage<TrainPartyUseCardScRsp>, IMessage, IEquatable<TrainPartyUseCardScRsp>, IDeepCloneable<TrainPartyUseCardScRsp>, IBufferMessage
{
	private static readonly MessageParser<TrainPartyUseCardScRsp> _parser = new MessageParser<TrainPartyUseCardScRsp>(() => new TrainPartyUseCardScRsp());

	private UnknownFieldSet _unknownFields;

	public const int RetcodeFieldNumber = 6;

	private uint retcode_;

	public const int GDFPBHMMFEAFieldNumber = 11;

	private uint gDFPBHMMFEA_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<TrainPartyUseCardScRsp> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => TrainPartyUseCardScRspReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

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
	public uint GDFPBHMMFEA
	{
		get
		{
			return gDFPBHMMFEA_;
		}
		set
		{
			gDFPBHMMFEA_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public TrainPartyUseCardScRsp()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public TrainPartyUseCardScRsp(TrainPartyUseCardScRsp other)
		: this()
	{
		retcode_ = other.retcode_;
		gDFPBHMMFEA_ = other.gDFPBHMMFEA_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public TrainPartyUseCardScRsp Clone()
	{
		return new TrainPartyUseCardScRsp(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as TrainPartyUseCardScRsp);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(TrainPartyUseCardScRsp other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (Retcode != other.Retcode)
		{
			return false;
		}
		if (GDFPBHMMFEA != other.GDFPBHMMFEA)
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
		if (Retcode != 0)
		{
			num ^= Retcode.GetHashCode();
		}
		if (GDFPBHMMFEA != 0)
		{
			num ^= GDFPBHMMFEA.GetHashCode();
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
		if (Retcode != 0)
		{
			output.WriteRawTag(48);
			output.WriteUInt32(Retcode);
		}
		if (GDFPBHMMFEA != 0)
		{
			output.WriteRawTag(88);
			output.WriteUInt32(GDFPBHMMFEA);
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
		if (Retcode != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Retcode);
		}
		if (GDFPBHMMFEA != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(GDFPBHMMFEA);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(TrainPartyUseCardScRsp other)
	{
		if (other != null)
		{
			if (other.Retcode != 0)
			{
				Retcode = other.Retcode;
			}
			if (other.GDFPBHMMFEA != 0)
			{
				GDFPBHMMFEA = other.GDFPBHMMFEA;
			}
			_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
		}
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
			case 48u:
				Retcode = input.ReadUInt32();
				break;
			case 88u:
				GDFPBHMMFEA = input.ReadUInt32();
				break;
			}
		}
	}
}
