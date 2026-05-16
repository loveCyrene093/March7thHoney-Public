using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class GetGachaCeilingScRsp : IMessage<GetGachaCeilingScRsp>, IMessage, IEquatable<GetGachaCeilingScRsp>, IDeepCloneable<GetGachaCeilingScRsp>, IBufferMessage
{
	private static readonly MessageParser<GetGachaCeilingScRsp> _parser = new MessageParser<GetGachaCeilingScRsp>(() => new GetGachaCeilingScRsp());

	private UnknownFieldSet _unknownFields;

	public const int GachaTypeFieldNumber = 2;

	private uint gachaType_;

	public const int RetcodeFieldNumber = 4;

	private uint retcode_;

	public const int GachaCeilingFieldNumber = 5;

	private GachaCeiling gachaCeiling_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<GetGachaCeilingScRsp> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => GetGachaCeilingScRspReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint GachaType
	{
		get
		{
			return gachaType_;
		}
		set
		{
			gachaType_ = value;
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
	public GachaCeiling GachaCeiling
	{
		get
		{
			return gachaCeiling_;
		}
		set
		{
			gachaCeiling_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GetGachaCeilingScRsp()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GetGachaCeilingScRsp(GetGachaCeilingScRsp other)
		: this()
	{
		gachaType_ = other.gachaType_;
		retcode_ = other.retcode_;
		gachaCeiling_ = ((other.gachaCeiling_ != null) ? other.gachaCeiling_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GetGachaCeilingScRsp Clone()
	{
		return new GetGachaCeilingScRsp(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as GetGachaCeilingScRsp);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(GetGachaCeilingScRsp other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (GachaType != other.GachaType)
		{
			return false;
		}
		if (Retcode != other.Retcode)
		{
			return false;
		}
		if (!object.Equals(GachaCeiling, other.GachaCeiling))
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
		if (GachaType != 0)
		{
			num ^= GachaType.GetHashCode();
		}
		if (Retcode != 0)
		{
			num ^= Retcode.GetHashCode();
		}
		if (gachaCeiling_ != null)
		{
			num ^= GachaCeiling.GetHashCode();
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
		if (GachaType != 0)
		{
			output.WriteRawTag(16);
			output.WriteUInt32(GachaType);
		}
		if (Retcode != 0)
		{
			output.WriteRawTag(32);
			output.WriteUInt32(Retcode);
		}
		if (gachaCeiling_ != null)
		{
			output.WriteRawTag(42);
			output.WriteMessage(GachaCeiling);
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
		if (GachaType != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(GachaType);
		}
		if (Retcode != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Retcode);
		}
		if (gachaCeiling_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(GachaCeiling);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(GetGachaCeilingScRsp other)
	{
		if (other == null)
		{
			return;
		}
		if (other.GachaType != 0)
		{
			GachaType = other.GachaType;
		}
		if (other.Retcode != 0)
		{
			Retcode = other.Retcode;
		}
		if (other.gachaCeiling_ != null)
		{
			if (gachaCeiling_ == null)
			{
				GachaCeiling = new GachaCeiling();
			}
			GachaCeiling.MergeFrom(other.GachaCeiling);
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
			case 16u:
				GachaType = input.ReadUInt32();
				break;
			case 32u:
				Retcode = input.ReadUInt32();
				break;
			case 42u:
				if (gachaCeiling_ == null)
				{
					GachaCeiling = new GachaCeiling();
				}
				input.ReadMessage(GachaCeiling);
				break;
			}
		}
	}
}
