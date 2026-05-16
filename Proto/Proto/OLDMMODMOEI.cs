using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class OLDMMODMOEI : IMessage<OLDMMODMOEI>, IMessage, IEquatable<OLDMMODMOEI>, IDeepCloneable<OLDMMODMOEI>, IBufferMessage
{
	private static readonly MessageParser<OLDMMODMOEI> _parser = new MessageParser<OLDMMODMOEI>(() => new OLDMMODMOEI());

	private UnknownFieldSet _unknownFields;

	public const int PPIPFOPHNHMFieldNumber = 6;

	private MNCOPDNELMC pPIPFOPHNHM_;

	public const int HJBOBCLEEDIFieldNumber = 11;

	private uint hJBOBCLEEDI_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<OLDMMODMOEI> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => OLDMMODMOEIReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MNCOPDNELMC PPIPFOPHNHM
	{
		get
		{
			return pPIPFOPHNHM_;
		}
		set
		{
			pPIPFOPHNHM_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint HJBOBCLEEDI
	{
		get
		{
			return hJBOBCLEEDI_;
		}
		set
		{
			hJBOBCLEEDI_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public OLDMMODMOEI()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public OLDMMODMOEI(OLDMMODMOEI other)
		: this()
	{
		pPIPFOPHNHM_ = ((other.pPIPFOPHNHM_ != null) ? other.pPIPFOPHNHM_.Clone() : null);
		hJBOBCLEEDI_ = other.hJBOBCLEEDI_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public OLDMMODMOEI Clone()
	{
		return new OLDMMODMOEI(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as OLDMMODMOEI);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(OLDMMODMOEI other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(PPIPFOPHNHM, other.PPIPFOPHNHM))
		{
			return false;
		}
		if (HJBOBCLEEDI != other.HJBOBCLEEDI)
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
		if (pPIPFOPHNHM_ != null)
		{
			num ^= PPIPFOPHNHM.GetHashCode();
		}
		if (HJBOBCLEEDI != 0)
		{
			num ^= HJBOBCLEEDI.GetHashCode();
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
		if (pPIPFOPHNHM_ != null)
		{
			output.WriteRawTag(50);
			output.WriteMessage(PPIPFOPHNHM);
		}
		if (HJBOBCLEEDI != 0)
		{
			output.WriteRawTag(88);
			output.WriteUInt32(HJBOBCLEEDI);
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
		if (pPIPFOPHNHM_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(PPIPFOPHNHM);
		}
		if (HJBOBCLEEDI != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(HJBOBCLEEDI);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(OLDMMODMOEI other)
	{
		if (other == null)
		{
			return;
		}
		if (other.pPIPFOPHNHM_ != null)
		{
			if (pPIPFOPHNHM_ == null)
			{
				PPIPFOPHNHM = new MNCOPDNELMC();
			}
			PPIPFOPHNHM.MergeFrom(other.PPIPFOPHNHM);
		}
		if (other.HJBOBCLEEDI != 0)
		{
			HJBOBCLEEDI = other.HJBOBCLEEDI;
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
			case 50u:
				if (pPIPFOPHNHM_ == null)
				{
					PPIPFOPHNHM = new MNCOPDNELMC();
				}
				input.ReadMessage(PPIPFOPHNHM);
				break;
			case 88u:
				HJBOBCLEEDI = input.ReadUInt32();
				break;
			}
		}
	}
}
