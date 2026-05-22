using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class AetherDivideSpiritExpUpScRsp : IMessage<AetherDivideSpiritExpUpScRsp>, IMessage, IEquatable<AetherDivideSpiritExpUpScRsp>, IDeepCloneable<AetherDivideSpiritExpUpScRsp>, IBufferMessage
{
	private static readonly MessageParser<AetherDivideSpiritExpUpScRsp> _parser = new MessageParser<AetherDivideSpiritExpUpScRsp>(() => new AetherDivideSpiritExpUpScRsp());

	private UnknownFieldSet _unknownFields;

	public const int HKOHIHCBGAAFieldNumber = 1;

	private KNHKBHADJGE hKOHIHCBGAA_;

	public const int FIKLLOCJBGNFieldNumber = 2;

	private uint fIKLLOCJBGN_;

	public const int RetcodeFieldNumber = 11;

	private uint retcode_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<AetherDivideSpiritExpUpScRsp> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => AetherDivideSpiritExpUpScRspReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public KNHKBHADJGE HKOHIHCBGAA
	{
		get
		{
			return hKOHIHCBGAA_;
		}
		set
		{
			hKOHIHCBGAA_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint FIKLLOCJBGN
	{
		get
		{
			return fIKLLOCJBGN_;
		}
		set
		{
			fIKLLOCJBGN_ = value;
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
	public AetherDivideSpiritExpUpScRsp()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AetherDivideSpiritExpUpScRsp(AetherDivideSpiritExpUpScRsp other)
		: this()
	{
		hKOHIHCBGAA_ = ((other.hKOHIHCBGAA_ != null) ? other.hKOHIHCBGAA_.Clone() : null);
		fIKLLOCJBGN_ = other.fIKLLOCJBGN_;
		retcode_ = other.retcode_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AetherDivideSpiritExpUpScRsp Clone()
	{
		return new AetherDivideSpiritExpUpScRsp(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as AetherDivideSpiritExpUpScRsp);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(AetherDivideSpiritExpUpScRsp other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(HKOHIHCBGAA, other.HKOHIHCBGAA))
		{
			return false;
		}
		if (FIKLLOCJBGN != other.FIKLLOCJBGN)
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
		if (hKOHIHCBGAA_ != null)
		{
			num ^= HKOHIHCBGAA.GetHashCode();
		}
		if (FIKLLOCJBGN != 0)
		{
			num ^= FIKLLOCJBGN.GetHashCode();
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
		if (hKOHIHCBGAA_ != null)
		{
			output.WriteRawTag(10);
			output.WriteMessage(HKOHIHCBGAA);
		}
		if (FIKLLOCJBGN != 0)
		{
			output.WriteRawTag(16);
			output.WriteUInt32(FIKLLOCJBGN);
		}
		if (Retcode != 0)
		{
			output.WriteRawTag(88);
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
		if (hKOHIHCBGAA_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(HKOHIHCBGAA);
		}
		if (FIKLLOCJBGN != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(FIKLLOCJBGN);
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
	public void MergeFrom(AetherDivideSpiritExpUpScRsp other)
	{
		if (other == null)
		{
			return;
		}
		if (other.hKOHIHCBGAA_ != null)
		{
			if (hKOHIHCBGAA_ == null)
			{
				HKOHIHCBGAA = new KNHKBHADJGE();
			}
			HKOHIHCBGAA.MergeFrom(other.HKOHIHCBGAA);
		}
		if (other.FIKLLOCJBGN != 0)
		{
			FIKLLOCJBGN = other.FIKLLOCJBGN;
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
			case 10u:
				if (hKOHIHCBGAA_ == null)
				{
					HKOHIHCBGAA = new KNHKBHADJGE();
				}
				input.ReadMessage(HKOHIHCBGAA);
				break;
			case 16u:
				FIKLLOCJBGN = input.ReadUInt32();
				break;
			case 88u:
				Retcode = input.ReadUInt32();
				break;
			}
		}
	}
}
