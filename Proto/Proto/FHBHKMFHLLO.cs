using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class FHBHKMFHLLO : IMessage<FHBHKMFHLLO>, IMessage, IEquatable<FHBHKMFHLLO>, IDeepCloneable<FHBHKMFHLLO>, IBufferMessage
{
	private static readonly MessageParser<FHBHKMFHLLO> _parser = new MessageParser<FHBHKMFHLLO>(() => new FHBHKMFHLLO());

	private UnknownFieldSet _unknownFields;

	public const int LDGJLDANJJLFieldNumber = 1;

	private uint lDGJLDANJJL_;

	public const int MGNGPGPPIAAFieldNumber = 2;

	private uint mGNGPGPPIAA_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<FHBHKMFHLLO> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => FHBHKMFHLLOReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint LDGJLDANJJL
	{
		get
		{
			return lDGJLDANJJL_;
		}
		set
		{
			lDGJLDANJJL_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint MGNGPGPPIAA
	{
		get
		{
			return mGNGPGPPIAA_;
		}
		set
		{
			mGNGPGPPIAA_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FHBHKMFHLLO()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FHBHKMFHLLO(FHBHKMFHLLO other)
		: this()
	{
		lDGJLDANJJL_ = other.lDGJLDANJJL_;
		mGNGPGPPIAA_ = other.mGNGPGPPIAA_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FHBHKMFHLLO Clone()
	{
		return new FHBHKMFHLLO(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as FHBHKMFHLLO);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(FHBHKMFHLLO other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (LDGJLDANJJL != other.LDGJLDANJJL)
		{
			return false;
		}
		if (MGNGPGPPIAA != other.MGNGPGPPIAA)
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
		if (LDGJLDANJJL != 0)
		{
			num ^= LDGJLDANJJL.GetHashCode();
		}
		if (MGNGPGPPIAA != 0)
		{
			num ^= MGNGPGPPIAA.GetHashCode();
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
		if (LDGJLDANJJL != 0)
		{
			output.WriteRawTag(8);
			output.WriteUInt32(LDGJLDANJJL);
		}
		if (MGNGPGPPIAA != 0)
		{
			output.WriteRawTag(16);
			output.WriteUInt32(MGNGPGPPIAA);
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
		if (LDGJLDANJJL != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(LDGJLDANJJL);
		}
		if (MGNGPGPPIAA != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(MGNGPGPPIAA);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(FHBHKMFHLLO other)
	{
		if (other != null)
		{
			if (other.LDGJLDANJJL != 0)
			{
				LDGJLDANJJL = other.LDGJLDANJJL;
			}
			if (other.MGNGPGPPIAA != 0)
			{
				MGNGPGPPIAA = other.MGNGPGPPIAA;
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
				LDGJLDANJJL = input.ReadUInt32();
				break;
			case 16u:
				MGNGPGPPIAA = input.ReadUInt32();
				break;
			}
		}
	}
}
