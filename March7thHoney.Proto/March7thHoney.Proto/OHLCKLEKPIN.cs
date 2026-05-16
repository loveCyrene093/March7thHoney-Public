using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class OHLCKLEKPIN : IMessage<OHLCKLEKPIN>, IMessage, IEquatable<OHLCKLEKPIN>, IDeepCloneable<OHLCKLEKPIN>, IBufferMessage
{
	private static readonly MessageParser<OHLCKLEKPIN> _parser = new MessageParser<OHLCKLEKPIN>(() => new OHLCKLEKPIN());

	private UnknownFieldSet _unknownFields;

	public const int ALIGEFKMMGHFieldNumber = 1;

	private long aLIGEFKMMGH_;

	public const int MJIDMBJNGEIFieldNumber = 2;

	private uint mJIDMBJNGEI_;

	public const int BGDBCAKJMMAFieldNumber = 5;

	private uint bGDBCAKJMMA_;

	public const int HasPassedFieldNumber = 7;

	private bool hasPassed_;

	public const int CFIONKKIPJLFieldNumber = 10;

	private bool cFIONKKIPJL_;

	public const int AFDBHGCAJDBFieldNumber = 13;

	private uint aFDBHGCAJDB_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<OHLCKLEKPIN> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => OHLCKLEKPINReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public long ALIGEFKMMGH
	{
		get
		{
			return aLIGEFKMMGH_;
		}
		set
		{
			aLIGEFKMMGH_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint MJIDMBJNGEI
	{
		get
		{
			return mJIDMBJNGEI_;
		}
		set
		{
			mJIDMBJNGEI_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint BGDBCAKJMMA
	{
		get
		{
			return bGDBCAKJMMA_;
		}
		set
		{
			bGDBCAKJMMA_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool HasPassed
	{
		get
		{
			return hasPassed_;
		}
		set
		{
			hasPassed_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool CFIONKKIPJL
	{
		get
		{
			return cFIONKKIPJL_;
		}
		set
		{
			cFIONKKIPJL_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint AFDBHGCAJDB
	{
		get
		{
			return aFDBHGCAJDB_;
		}
		set
		{
			aFDBHGCAJDB_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public OHLCKLEKPIN()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public OHLCKLEKPIN(OHLCKLEKPIN other)
		: this()
	{
		aLIGEFKMMGH_ = other.aLIGEFKMMGH_;
		mJIDMBJNGEI_ = other.mJIDMBJNGEI_;
		bGDBCAKJMMA_ = other.bGDBCAKJMMA_;
		hasPassed_ = other.hasPassed_;
		cFIONKKIPJL_ = other.cFIONKKIPJL_;
		aFDBHGCAJDB_ = other.aFDBHGCAJDB_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public OHLCKLEKPIN Clone()
	{
		return new OHLCKLEKPIN(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as OHLCKLEKPIN);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(OHLCKLEKPIN other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (ALIGEFKMMGH != other.ALIGEFKMMGH)
		{
			return false;
		}
		if (MJIDMBJNGEI != other.MJIDMBJNGEI)
		{
			return false;
		}
		if (BGDBCAKJMMA != other.BGDBCAKJMMA)
		{
			return false;
		}
		if (HasPassed != other.HasPassed)
		{
			return false;
		}
		if (CFIONKKIPJL != other.CFIONKKIPJL)
		{
			return false;
		}
		if (AFDBHGCAJDB != other.AFDBHGCAJDB)
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
		if (ALIGEFKMMGH != 0L)
		{
			num ^= ALIGEFKMMGH.GetHashCode();
		}
		if (MJIDMBJNGEI != 0)
		{
			num ^= MJIDMBJNGEI.GetHashCode();
		}
		if (BGDBCAKJMMA != 0)
		{
			num ^= BGDBCAKJMMA.GetHashCode();
		}
		if (HasPassed)
		{
			num ^= HasPassed.GetHashCode();
		}
		if (CFIONKKIPJL)
		{
			num ^= CFIONKKIPJL.GetHashCode();
		}
		if (AFDBHGCAJDB != 0)
		{
			num ^= AFDBHGCAJDB.GetHashCode();
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
		if (ALIGEFKMMGH != 0L)
		{
			output.WriteRawTag(8);
			output.WriteInt64(ALIGEFKMMGH);
		}
		if (MJIDMBJNGEI != 0)
		{
			output.WriteRawTag(16);
			output.WriteUInt32(MJIDMBJNGEI);
		}
		if (BGDBCAKJMMA != 0)
		{
			output.WriteRawTag(40);
			output.WriteUInt32(BGDBCAKJMMA);
		}
		if (HasPassed)
		{
			output.WriteRawTag(56);
			output.WriteBool(HasPassed);
		}
		if (CFIONKKIPJL)
		{
			output.WriteRawTag(80);
			output.WriteBool(CFIONKKIPJL);
		}
		if (AFDBHGCAJDB != 0)
		{
			output.WriteRawTag(104);
			output.WriteUInt32(AFDBHGCAJDB);
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
		if (ALIGEFKMMGH != 0L)
		{
			num += 1 + CodedOutputStream.ComputeInt64Size(ALIGEFKMMGH);
		}
		if (MJIDMBJNGEI != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(MJIDMBJNGEI);
		}
		if (BGDBCAKJMMA != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(BGDBCAKJMMA);
		}
		if (HasPassed)
		{
			num += 2;
		}
		if (CFIONKKIPJL)
		{
			num += 2;
		}
		if (AFDBHGCAJDB != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(AFDBHGCAJDB);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(OHLCKLEKPIN other)
	{
		if (other != null)
		{
			if (other.ALIGEFKMMGH != 0L)
			{
				ALIGEFKMMGH = other.ALIGEFKMMGH;
			}
			if (other.MJIDMBJNGEI != 0)
			{
				MJIDMBJNGEI = other.MJIDMBJNGEI;
			}
			if (other.BGDBCAKJMMA != 0)
			{
				BGDBCAKJMMA = other.BGDBCAKJMMA;
			}
			if (other.HasPassed)
			{
				HasPassed = other.HasPassed;
			}
			if (other.CFIONKKIPJL)
			{
				CFIONKKIPJL = other.CFIONKKIPJL;
			}
			if (other.AFDBHGCAJDB != 0)
			{
				AFDBHGCAJDB = other.AFDBHGCAJDB;
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
				ALIGEFKMMGH = input.ReadInt64();
				break;
			case 16u:
				MJIDMBJNGEI = input.ReadUInt32();
				break;
			case 40u:
				BGDBCAKJMMA = input.ReadUInt32();
				break;
			case 56u:
				HasPassed = input.ReadBool();
				break;
			case 80u:
				CFIONKKIPJL = input.ReadBool();
				break;
			case 104u:
				AFDBHGCAJDB = input.ReadUInt32();
				break;
			}
		}
	}
}
