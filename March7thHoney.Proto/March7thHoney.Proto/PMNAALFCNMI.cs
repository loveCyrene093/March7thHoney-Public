using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class PMNAALFCNMI : IMessage<PMNAALFCNMI>, IMessage, IEquatable<PMNAALFCNMI>, IDeepCloneable<PMNAALFCNMI>, IBufferMessage
{
	private static readonly MessageParser<PMNAALFCNMI> _parser = new MessageParser<PMNAALFCNMI>(() => new PMNAALFCNMI());

	private UnknownFieldSet _unknownFields;

	public const int PENLMEIJIFKFieldNumber = 1;

	private uint pENLMEIJIFK_;

	public const int GEFGOIGJHFJFieldNumber = 2;

	private ulong gEFGOIGJHFJ_;

	public const int LevelFieldNumber = 4;

	private uint level_;

	public const int MOOOPAMBOFKFieldNumber = 14;

	private uint mOOOPAMBOFK_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<PMNAALFCNMI> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => PMNAALFCNMIReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

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
	public PMNAALFCNMI()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PMNAALFCNMI(PMNAALFCNMI other)
		: this()
	{
		pENLMEIJIFK_ = other.pENLMEIJIFK_;
		gEFGOIGJHFJ_ = other.gEFGOIGJHFJ_;
		level_ = other.level_;
		mOOOPAMBOFK_ = other.mOOOPAMBOFK_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PMNAALFCNMI Clone()
	{
		return new PMNAALFCNMI(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as PMNAALFCNMI);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(PMNAALFCNMI other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (PENLMEIJIFK != other.PENLMEIJIFK)
		{
			return false;
		}
		if (GEFGOIGJHFJ != other.GEFGOIGJHFJ)
		{
			return false;
		}
		if (Level != other.Level)
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
		if (PENLMEIJIFK != 0)
		{
			num ^= PENLMEIJIFK.GetHashCode();
		}
		if (GEFGOIGJHFJ != 0L)
		{
			num ^= GEFGOIGJHFJ.GetHashCode();
		}
		if (Level != 0)
		{
			num ^= Level.GetHashCode();
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
		if (PENLMEIJIFK != 0)
		{
			output.WriteRawTag(8);
			output.WriteUInt32(PENLMEIJIFK);
		}
		if (GEFGOIGJHFJ != 0L)
		{
			output.WriteRawTag(16);
			output.WriteUInt64(GEFGOIGJHFJ);
		}
		if (Level != 0)
		{
			output.WriteRawTag(32);
			output.WriteUInt32(Level);
		}
		if (MOOOPAMBOFK != 0)
		{
			output.WriteRawTag(112);
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
		if (PENLMEIJIFK != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(PENLMEIJIFK);
		}
		if (GEFGOIGJHFJ != 0L)
		{
			num += 1 + CodedOutputStream.ComputeUInt64Size(GEFGOIGJHFJ);
		}
		if (Level != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Level);
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
	public void MergeFrom(PMNAALFCNMI other)
	{
		if (other != null)
		{
			if (other.PENLMEIJIFK != 0)
			{
				PENLMEIJIFK = other.PENLMEIJIFK;
			}
			if (other.GEFGOIGJHFJ != 0L)
			{
				GEFGOIGJHFJ = other.GEFGOIGJHFJ;
			}
			if (other.Level != 0)
			{
				Level = other.Level;
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
			case 8u:
				PENLMEIJIFK = input.ReadUInt32();
				break;
			case 16u:
				GEFGOIGJHFJ = input.ReadUInt64();
				break;
			case 32u:
				Level = input.ReadUInt32();
				break;
			case 112u:
				MOOOPAMBOFK = input.ReadUInt32();
				break;
			}
		}
	}
}
