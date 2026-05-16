using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class POCFNJMAHMD : IMessage<POCFNJMAHMD>, IMessage, IEquatable<POCFNJMAHMD>, IDeepCloneable<POCFNJMAHMD>, IBufferMessage
{
	private static readonly MessageParser<POCFNJMAHMD> _parser = new MessageParser<POCFNJMAHMD>(() => new POCFNJMAHMD());

	private UnknownFieldSet _unknownFields;

	public const int LevelFieldNumber = 2;

	private uint level_;

	public const int PENLMEIJIFKFieldNumber = 4;

	private uint pENLMEIJIFK_;

	public const int MOOOPAMBOFKFieldNumber = 8;

	private uint mOOOPAMBOFK_;

	public const int GEFGOIGJHFJFieldNumber = 13;

	private ulong gEFGOIGJHFJ_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<POCFNJMAHMD> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => POCFNJMAHMDReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

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
	public uint PENLMEIJIFK
	{
		get
		{
			return pENLMEIJIFK_;
		}
		set
		{
			pENLMEIJIFK_ = value;
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
	public POCFNJMAHMD()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public POCFNJMAHMD(POCFNJMAHMD other)
		: this()
	{
		level_ = other.level_;
		pENLMEIJIFK_ = other.pENLMEIJIFK_;
		mOOOPAMBOFK_ = other.mOOOPAMBOFK_;
		gEFGOIGJHFJ_ = other.gEFGOIGJHFJ_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public POCFNJMAHMD Clone()
	{
		return new POCFNJMAHMD(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as POCFNJMAHMD);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(POCFNJMAHMD other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (Level != other.Level)
		{
			return false;
		}
		if (PENLMEIJIFK != other.PENLMEIJIFK)
		{
			return false;
		}
		if (MOOOPAMBOFK != other.MOOOPAMBOFK)
		{
			return false;
		}
		if (GEFGOIGJHFJ != other.GEFGOIGJHFJ)
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
		if (Level != 0)
		{
			num ^= Level.GetHashCode();
		}
		if (PENLMEIJIFK != 0)
		{
			num ^= PENLMEIJIFK.GetHashCode();
		}
		if (MOOOPAMBOFK != 0)
		{
			num ^= MOOOPAMBOFK.GetHashCode();
		}
		if (GEFGOIGJHFJ != 0L)
		{
			num ^= GEFGOIGJHFJ.GetHashCode();
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
		if (Level != 0)
		{
			output.WriteRawTag(16);
			output.WriteUInt32(Level);
		}
		if (PENLMEIJIFK != 0)
		{
			output.WriteRawTag(32);
			output.WriteUInt32(PENLMEIJIFK);
		}
		if (MOOOPAMBOFK != 0)
		{
			output.WriteRawTag(64);
			output.WriteUInt32(MOOOPAMBOFK);
		}
		if (GEFGOIGJHFJ != 0L)
		{
			output.WriteRawTag(104);
			output.WriteUInt64(GEFGOIGJHFJ);
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
		if (Level != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Level);
		}
		if (PENLMEIJIFK != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(PENLMEIJIFK);
		}
		if (MOOOPAMBOFK != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(MOOOPAMBOFK);
		}
		if (GEFGOIGJHFJ != 0L)
		{
			num += 1 + CodedOutputStream.ComputeUInt64Size(GEFGOIGJHFJ);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(POCFNJMAHMD other)
	{
		if (other != null)
		{
			if (other.Level != 0)
			{
				Level = other.Level;
			}
			if (other.PENLMEIJIFK != 0)
			{
				PENLMEIJIFK = other.PENLMEIJIFK;
			}
			if (other.MOOOPAMBOFK != 0)
			{
				MOOOPAMBOFK = other.MOOOPAMBOFK;
			}
			if (other.GEFGOIGJHFJ != 0L)
			{
				GEFGOIGJHFJ = other.GEFGOIGJHFJ;
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
			case 16u:
				Level = input.ReadUInt32();
				break;
			case 32u:
				PENLMEIJIFK = input.ReadUInt32();
				break;
			case 64u:
				MOOOPAMBOFK = input.ReadUInt32();
				break;
			case 104u:
				GEFGOIGJHFJ = input.ReadUInt64();
				break;
			}
		}
	}
}
