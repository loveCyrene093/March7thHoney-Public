using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class LHEDJAIOHOE : IMessage<LHEDJAIOHOE>, IMessage, IEquatable<LHEDJAIOHOE>, IDeepCloneable<LHEDJAIOHOE>, IBufferMessage
{
	private static readonly MessageParser<LHEDJAIOHOE> _parser = new MessageParser<LHEDJAIOHOE>(() => new LHEDJAIOHOE());

	private UnknownFieldSet _unknownFields;

	public const int NJDBIEMAOAAFieldNumber = 8;

	private uint nJDBIEMAOAA_;

	public const int MAONLHBKOFKFieldNumber = 10;

	private uint mAONLHBKOFK_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<LHEDJAIOHOE> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => LHEDJAIOHOEReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint NJDBIEMAOAA
	{
		get
		{
			return nJDBIEMAOAA_;
		}
		set
		{
			nJDBIEMAOAA_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint MAONLHBKOFK
	{
		get
		{
			return mAONLHBKOFK_;
		}
		set
		{
			mAONLHBKOFK_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public LHEDJAIOHOE()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public LHEDJAIOHOE(LHEDJAIOHOE other)
		: this()
	{
		nJDBIEMAOAA_ = other.nJDBIEMAOAA_;
		mAONLHBKOFK_ = other.mAONLHBKOFK_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public LHEDJAIOHOE Clone()
	{
		return new LHEDJAIOHOE(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as LHEDJAIOHOE);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(LHEDJAIOHOE other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (NJDBIEMAOAA != other.NJDBIEMAOAA)
		{
			return false;
		}
		if (MAONLHBKOFK != other.MAONLHBKOFK)
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
		if (NJDBIEMAOAA != 0)
		{
			num ^= NJDBIEMAOAA.GetHashCode();
		}
		if (MAONLHBKOFK != 0)
		{
			num ^= MAONLHBKOFK.GetHashCode();
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
		if (NJDBIEMAOAA != 0)
		{
			output.WriteRawTag(64);
			output.WriteUInt32(NJDBIEMAOAA);
		}
		if (MAONLHBKOFK != 0)
		{
			output.WriteRawTag(80);
			output.WriteUInt32(MAONLHBKOFK);
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
		if (NJDBIEMAOAA != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(NJDBIEMAOAA);
		}
		if (MAONLHBKOFK != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(MAONLHBKOFK);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(LHEDJAIOHOE other)
	{
		if (other != null)
		{
			if (other.NJDBIEMAOAA != 0)
			{
				NJDBIEMAOAA = other.NJDBIEMAOAA;
			}
			if (other.MAONLHBKOFK != 0)
			{
				MAONLHBKOFK = other.MAONLHBKOFK;
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
			case 64u:
				NJDBIEMAOAA = input.ReadUInt32();
				break;
			case 80u:
				MAONLHBKOFK = input.ReadUInt32();
				break;
			}
		}
	}
}
