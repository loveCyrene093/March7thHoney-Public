using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class FarmElementSweepScRsp : IMessage<FarmElementSweepScRsp>, IMessage, IEquatable<FarmElementSweepScRsp>, IDeepCloneable<FarmElementSweepScRsp>, IBufferMessage
{
	private static readonly MessageParser<FarmElementSweepScRsp> _parser = new MessageParser<FarmElementSweepScRsp>(() => new FarmElementSweepScRsp());

	private UnknownFieldSet _unknownFields;

	public const int FarmElementIdFieldNumber = 6;

	private uint farmElementId_;

	public const int RetcodeFieldNumber = 12;

	private uint retcode_;

	public const int MultipleDropDataFieldNumber = 14;

	private ItemList multipleDropData_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<FarmElementSweepScRsp> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => FarmElementSweepScRspReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint FarmElementId
	{
		get
		{
			return farmElementId_;
		}
		set
		{
			farmElementId_ = value;
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
	public ItemList MultipleDropData
	{
		get
		{
			return multipleDropData_;
		}
		set
		{
			multipleDropData_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FarmElementSweepScRsp()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FarmElementSweepScRsp(FarmElementSweepScRsp other)
		: this()
	{
		farmElementId_ = other.farmElementId_;
		retcode_ = other.retcode_;
		multipleDropData_ = ((other.multipleDropData_ != null) ? other.multipleDropData_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FarmElementSweepScRsp Clone()
	{
		return new FarmElementSweepScRsp(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as FarmElementSweepScRsp);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(FarmElementSweepScRsp other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (FarmElementId != other.FarmElementId)
		{
			return false;
		}
		if (Retcode != other.Retcode)
		{
			return false;
		}
		if (!object.Equals(MultipleDropData, other.MultipleDropData))
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
		if (FarmElementId != 0)
		{
			num ^= FarmElementId.GetHashCode();
		}
		if (Retcode != 0)
		{
			num ^= Retcode.GetHashCode();
		}
		if (multipleDropData_ != null)
		{
			num ^= MultipleDropData.GetHashCode();
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
		if (FarmElementId != 0)
		{
			output.WriteRawTag(48);
			output.WriteUInt32(FarmElementId);
		}
		if (Retcode != 0)
		{
			output.WriteRawTag(96);
			output.WriteUInt32(Retcode);
		}
		if (multipleDropData_ != null)
		{
			output.WriteRawTag(114);
			output.WriteMessage(MultipleDropData);
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
		if (FarmElementId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(FarmElementId);
		}
		if (Retcode != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Retcode);
		}
		if (multipleDropData_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(MultipleDropData);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(FarmElementSweepScRsp other)
	{
		if (other == null)
		{
			return;
		}
		if (other.FarmElementId != 0)
		{
			FarmElementId = other.FarmElementId;
		}
		if (other.Retcode != 0)
		{
			Retcode = other.Retcode;
		}
		if (other.multipleDropData_ != null)
		{
			if (multipleDropData_ == null)
			{
				MultipleDropData = new ItemList();
			}
			MultipleDropData.MergeFrom(other.MultipleDropData);
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
			case 48u:
				FarmElementId = input.ReadUInt32();
				break;
			case 96u:
				Retcode = input.ReadUInt32();
				break;
			case 114u:
				if (multipleDropData_ == null)
				{
					MultipleDropData = new ItemList();
				}
				input.ReadMessage(MultipleDropData);
				break;
			}
		}
	}
}
