using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class AACDBCKAFCA : IMessage<AACDBCKAFCA>, IMessage, IEquatable<AACDBCKAFCA>, IDeepCloneable<AACDBCKAFCA>, IBufferMessage
{
	private static readonly MessageParser<AACDBCKAFCA> _parser = new MessageParser<AACDBCKAFCA>(() => new AACDBCKAFCA());

	private UnknownFieldSet _unknownFields;

	public const int GEFGOIGJHFJFieldNumber = 6;

	private ulong gEFGOIGJHFJ_;

	public const int MOOOPAMBOFKFieldNumber = 7;

	private uint mOOOPAMBOFK_;

	public const int LevelFieldNumber = 9;

	private uint level_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<AACDBCKAFCA> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => AACDBCKAFCAReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ulong GEFGOIGJHFJ
	{
		get
		{
			return gEFGOIGJHFJ_;
		}
		set
		{
			gEFGOIGJHFJ_ = value;
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
	public uint Level
	{
		get
		{
			return level_;
		}
		set
		{
			level_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AACDBCKAFCA()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AACDBCKAFCA(AACDBCKAFCA other)
		: this()
	{
		gEFGOIGJHFJ_ = other.gEFGOIGJHFJ_;
		mOOOPAMBOFK_ = other.mOOOPAMBOFK_;
		level_ = other.level_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AACDBCKAFCA Clone()
	{
		return new AACDBCKAFCA(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as AACDBCKAFCA);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(AACDBCKAFCA other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (GEFGOIGJHFJ != other.GEFGOIGJHFJ)
		{
			return false;
		}
		if (MOOOPAMBOFK != other.MOOOPAMBOFK)
		{
			return false;
		}
		if (Level != other.Level)
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
		if (GEFGOIGJHFJ != 0L)
		{
			num ^= GEFGOIGJHFJ.GetHashCode();
		}
		if (MOOOPAMBOFK != 0)
		{
			num ^= MOOOPAMBOFK.GetHashCode();
		}
		if (Level != 0)
		{
			num ^= Level.GetHashCode();
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
		if (GEFGOIGJHFJ != 0L)
		{
			output.WriteRawTag(48);
			output.WriteUInt64(GEFGOIGJHFJ);
		}
		if (MOOOPAMBOFK != 0)
		{
			output.WriteRawTag(56);
			output.WriteUInt32(MOOOPAMBOFK);
		}
		if (Level != 0)
		{
			output.WriteRawTag(72);
			output.WriteUInt32(Level);
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
		if (GEFGOIGJHFJ != 0L)
		{
			num += 1 + CodedOutputStream.ComputeUInt64Size(GEFGOIGJHFJ);
		}
		if (MOOOPAMBOFK != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(MOOOPAMBOFK);
		}
		if (Level != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Level);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(AACDBCKAFCA other)
	{
		if (other != null)
		{
			if (other.GEFGOIGJHFJ != 0L)
			{
				GEFGOIGJHFJ = other.GEFGOIGJHFJ;
			}
			if (other.MOOOPAMBOFK != 0)
			{
				MOOOPAMBOFK = other.MOOOPAMBOFK;
			}
			if (other.Level != 0)
			{
				Level = other.Level;
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
				GEFGOIGJHFJ = input.ReadUInt64();
				break;
			case 56u:
				MOOOPAMBOFK = input.ReadUInt32();
				break;
			case 72u:
				Level = input.ReadUInt32();
				break;
			}
		}
	}
}
