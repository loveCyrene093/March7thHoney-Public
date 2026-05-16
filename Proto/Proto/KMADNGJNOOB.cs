using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class KMADNGJNOOB : IMessage<KMADNGJNOOB>, IMessage, IEquatable<KMADNGJNOOB>, IDeepCloneable<KMADNGJNOOB>, IBufferMessage
{
	private static readonly MessageParser<KMADNGJNOOB> _parser = new MessageParser<KMADNGJNOOB>(() => new KMADNGJNOOB());

	private UnknownFieldSet _unknownFields;

	public const int HCHCOAPJLMGFieldNumber = 3;

	private uint hCHCOAPJLMG_;

	public const int MDFMEDKNEHGFieldNumber = 6;

	private uint mDFMEDKNEHG_;

	public const int GroupIdFieldNumber = 8;

	private uint groupId_;

	public const int MOOOPAMBOFKFieldNumber = 11;

	private uint mOOOPAMBOFK_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<KMADNGJNOOB> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => KMADNGJNOOBReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint HCHCOAPJLMG
	{
		get
		{
			return hCHCOAPJLMG_;
		}
		set
		{
			hCHCOAPJLMG_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint MDFMEDKNEHG
	{
		get
		{
			return mDFMEDKNEHG_;
		}
		set
		{
			mDFMEDKNEHG_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint GroupId
	{
		get
		{
			return groupId_;
		}
		set
		{
			groupId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint MOOOPAMBOFK
	{
		get
		{
			return mOOOPAMBOFK_;
		}
		set
		{
			mOOOPAMBOFK_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public KMADNGJNOOB()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public KMADNGJNOOB(KMADNGJNOOB other)
		: this()
	{
		hCHCOAPJLMG_ = other.hCHCOAPJLMG_;
		mDFMEDKNEHG_ = other.mDFMEDKNEHG_;
		groupId_ = other.groupId_;
		mOOOPAMBOFK_ = other.mOOOPAMBOFK_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public KMADNGJNOOB Clone()
	{
		return new KMADNGJNOOB(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as KMADNGJNOOB);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(KMADNGJNOOB other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (HCHCOAPJLMG != other.HCHCOAPJLMG)
		{
			return false;
		}
		if (MDFMEDKNEHG != other.MDFMEDKNEHG)
		{
			return false;
		}
		if (GroupId != other.GroupId)
		{
			return false;
		}
		if (MOOOPAMBOFK != other.MOOOPAMBOFK)
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
		if (HCHCOAPJLMG != 0)
		{
			num ^= HCHCOAPJLMG.GetHashCode();
		}
		if (MDFMEDKNEHG != 0)
		{
			num ^= MDFMEDKNEHG.GetHashCode();
		}
		if (GroupId != 0)
		{
			num ^= GroupId.GetHashCode();
		}
		if (MOOOPAMBOFK != 0)
		{
			num ^= MOOOPAMBOFK.GetHashCode();
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
		if (HCHCOAPJLMG != 0)
		{
			output.WriteRawTag(24);
			output.WriteUInt32(HCHCOAPJLMG);
		}
		if (MDFMEDKNEHG != 0)
		{
			output.WriteRawTag(48);
			output.WriteUInt32(MDFMEDKNEHG);
		}
		if (GroupId != 0)
		{
			output.WriteRawTag(64);
			output.WriteUInt32(GroupId);
		}
		if (MOOOPAMBOFK != 0)
		{
			output.WriteRawTag(88);
			output.WriteUInt32(MOOOPAMBOFK);
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
		if (HCHCOAPJLMG != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(HCHCOAPJLMG);
		}
		if (MDFMEDKNEHG != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(MDFMEDKNEHG);
		}
		if (GroupId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(GroupId);
		}
		if (MOOOPAMBOFK != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(MOOOPAMBOFK);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(KMADNGJNOOB other)
	{
		if (other != null)
		{
			if (other.HCHCOAPJLMG != 0)
			{
				HCHCOAPJLMG = other.HCHCOAPJLMG;
			}
			if (other.MDFMEDKNEHG != 0)
			{
				MDFMEDKNEHG = other.MDFMEDKNEHG;
			}
			if (other.GroupId != 0)
			{
				GroupId = other.GroupId;
			}
			if (other.MOOOPAMBOFK != 0)
			{
				MOOOPAMBOFK = other.MOOOPAMBOFK;
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
			case 24u:
				HCHCOAPJLMG = input.ReadUInt32();
				break;
			case 48u:
				MDFMEDKNEHG = input.ReadUInt32();
				break;
			case 64u:
				GroupId = input.ReadUInt32();
				break;
			case 88u:
				MOOOPAMBOFK = input.ReadUInt32();
				break;
			}
		}
	}
}
