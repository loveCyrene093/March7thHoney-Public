using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class MakeMissionDrinkCsReq : IMessage<MakeMissionDrinkCsReq>, IMessage, IEquatable<MakeMissionDrinkCsReq>, IDeepCloneable<MakeMissionDrinkCsReq>, IBufferMessage
{
	private static readonly MessageParser<MakeMissionDrinkCsReq> _parser = new MessageParser<MakeMissionDrinkCsReq>(() => new MakeMissionDrinkCsReq());

	private UnknownFieldSet _unknownFields;

	public const int JACCJGBGJOAFieldNumber = 1;

	private uint jACCJGBGJOA_;

	public const int IHDMLHFAEKHFieldNumber = 11;

	private CIGKBDIGGOI iHDMLHFAEKH_;

	public const int IsSaveFieldNumber = 14;

	private bool isSave_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<MakeMissionDrinkCsReq> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => MakeMissionDrinkCsReqReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint JACCJGBGJOA
	{
		get
		{
			return jACCJGBGJOA_;
		}
		set
		{
			jACCJGBGJOA_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CIGKBDIGGOI IHDMLHFAEKH
	{
		get
		{
			return iHDMLHFAEKH_;
		}
		set
		{
			iHDMLHFAEKH_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool IsSave
	{
		get
		{
			return isSave_;
		}
		set
		{
			isSave_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MakeMissionDrinkCsReq()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MakeMissionDrinkCsReq(MakeMissionDrinkCsReq other)
		: this()
	{
		jACCJGBGJOA_ = other.jACCJGBGJOA_;
		iHDMLHFAEKH_ = ((other.iHDMLHFAEKH_ != null) ? other.iHDMLHFAEKH_.Clone() : null);
		isSave_ = other.isSave_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MakeMissionDrinkCsReq Clone()
	{
		return new MakeMissionDrinkCsReq(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as MakeMissionDrinkCsReq);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(MakeMissionDrinkCsReq other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (JACCJGBGJOA != other.JACCJGBGJOA)
		{
			return false;
		}
		if (!object.Equals(IHDMLHFAEKH, other.IHDMLHFAEKH))
		{
			return false;
		}
		if (IsSave != other.IsSave)
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
		if (JACCJGBGJOA != 0)
		{
			num ^= JACCJGBGJOA.GetHashCode();
		}
		if (iHDMLHFAEKH_ != null)
		{
			num ^= IHDMLHFAEKH.GetHashCode();
		}
		if (IsSave)
		{
			num ^= IsSave.GetHashCode();
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
		if (JACCJGBGJOA != 0)
		{
			output.WriteRawTag(8);
			output.WriteUInt32(JACCJGBGJOA);
		}
		if (iHDMLHFAEKH_ != null)
		{
			output.WriteRawTag(90);
			output.WriteMessage(IHDMLHFAEKH);
		}
		if (IsSave)
		{
			output.WriteRawTag(112);
			output.WriteBool(IsSave);
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
		if (JACCJGBGJOA != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(JACCJGBGJOA);
		}
		if (iHDMLHFAEKH_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(IHDMLHFAEKH);
		}
		if (IsSave)
		{
			num += 2;
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(MakeMissionDrinkCsReq other)
	{
		if (other == null)
		{
			return;
		}
		if (other.JACCJGBGJOA != 0)
		{
			JACCJGBGJOA = other.JACCJGBGJOA;
		}
		if (other.iHDMLHFAEKH_ != null)
		{
			if (iHDMLHFAEKH_ == null)
			{
				IHDMLHFAEKH = new CIGKBDIGGOI();
			}
			IHDMLHFAEKH.MergeFrom(other.IHDMLHFAEKH);
		}
		if (other.IsSave)
		{
			IsSave = other.IsSave;
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
			case 8u:
				JACCJGBGJOA = input.ReadUInt32();
				break;
			case 90u:
				if (iHDMLHFAEKH_ == null)
				{
					IHDMLHFAEKH = new CIGKBDIGGOI();
				}
				input.ReadMessage(IHDMLHFAEKH);
				break;
			case 112u:
				IsSave = input.ReadBool();
				break;
			}
		}
	}
}
