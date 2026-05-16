using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class EquipSkillCoreScRsp : IMessage<EquipSkillCoreScRsp>, IMessage, IEquatable<EquipSkillCoreScRsp>, IDeepCloneable<EquipSkillCoreScRsp>, IBufferMessage
{
	private static readonly MessageParser<EquipSkillCoreScRsp> _parser = new MessageParser<EquipSkillCoreScRsp>(() => new EquipSkillCoreScRsp());

	private UnknownFieldSet _unknownFields;

	public const int HKOHIHCBGAAFieldNumber = 1;

	private KNHKBHADJGE hKOHIHCBGAA_;

	public const int GCNDOIMACANFieldNumber = 11;

	private JBJIKJGEBAH gCNDOIMACAN_;

	public const int RetcodeFieldNumber = 14;

	private uint retcode_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<EquipSkillCoreScRsp> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => EquipSkillCoreScRspReflection.Descriptor.MessageTypes[0];

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
	public JBJIKJGEBAH GCNDOIMACAN
	{
		get
		{
			return gCNDOIMACAN_;
		}
		set
		{
			gCNDOIMACAN_ = value;
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
	public EquipSkillCoreScRsp()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EquipSkillCoreScRsp(EquipSkillCoreScRsp other)
		: this()
	{
		hKOHIHCBGAA_ = ((other.hKOHIHCBGAA_ != null) ? other.hKOHIHCBGAA_.Clone() : null);
		gCNDOIMACAN_ = ((other.gCNDOIMACAN_ != null) ? other.gCNDOIMACAN_.Clone() : null);
		retcode_ = other.retcode_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EquipSkillCoreScRsp Clone()
	{
		return new EquipSkillCoreScRsp(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as EquipSkillCoreScRsp);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(EquipSkillCoreScRsp other)
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
		if (!object.Equals(GCNDOIMACAN, other.GCNDOIMACAN))
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
		if (gCNDOIMACAN_ != null)
		{
			num ^= GCNDOIMACAN.GetHashCode();
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
		if (gCNDOIMACAN_ != null)
		{
			output.WriteRawTag(90);
			output.WriteMessage(GCNDOIMACAN);
		}
		if (Retcode != 0)
		{
			output.WriteRawTag(112);
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
		if (gCNDOIMACAN_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(GCNDOIMACAN);
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
	public void MergeFrom(EquipSkillCoreScRsp other)
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
		if (other.gCNDOIMACAN_ != null)
		{
			if (gCNDOIMACAN_ == null)
			{
				GCNDOIMACAN = new JBJIKJGEBAH();
			}
			GCNDOIMACAN.MergeFrom(other.GCNDOIMACAN);
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
			case 90u:
				if (gCNDOIMACAN_ == null)
				{
					GCNDOIMACAN = new JBJIKJGEBAH();
				}
				input.ReadMessage(GCNDOIMACAN);
				break;
			case 112u:
				Retcode = input.ReadUInt32();
				break;
			}
		}
	}
}
