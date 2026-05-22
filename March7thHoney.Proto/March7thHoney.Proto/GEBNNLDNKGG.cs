using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class GEBNNLDNKGG : IMessage<GEBNNLDNKGG>, IMessage, IEquatable<GEBNNLDNKGG>, IDeepCloneable<GEBNNLDNKGG>, IBufferMessage
{
	private static readonly MessageParser<GEBNNLDNKGG> _parser = new MessageParser<GEBNNLDNKGG>(() => new GEBNNLDNKGG());

	private UnknownFieldSet _unknownFields;

	public const int NIECFPJPGOBFieldNumber = 3;

	private uint nIECFPJPGOB_;

	public const int AEILFKMAJGNFieldNumber = 4;

	private uint aEILFKMAJGN_;

	public const int BNLHIMHFGDKFieldNumber = 13;

	private uint bNLHIMHFGDK_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<GEBNNLDNKGG> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => GEBNNLDNKGGReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint NIECFPJPGOB
	{
		get
		{
			return nIECFPJPGOB_;
		}
		set
		{
			nIECFPJPGOB_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint AEILFKMAJGN
	{
		get
		{
			return aEILFKMAJGN_;
		}
		set
		{
			aEILFKMAJGN_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint BNLHIMHFGDK
	{
		get
		{
			return bNLHIMHFGDK_;
		}
		set
		{
			bNLHIMHFGDK_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GEBNNLDNKGG()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GEBNNLDNKGG(GEBNNLDNKGG other)
		: this()
	{
		nIECFPJPGOB_ = other.nIECFPJPGOB_;
		aEILFKMAJGN_ = other.aEILFKMAJGN_;
		bNLHIMHFGDK_ = other.bNLHIMHFGDK_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GEBNNLDNKGG Clone()
	{
		return new GEBNNLDNKGG(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as GEBNNLDNKGG);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(GEBNNLDNKGG other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (NIECFPJPGOB != other.NIECFPJPGOB)
		{
			return false;
		}
		if (AEILFKMAJGN != other.AEILFKMAJGN)
		{
			return false;
		}
		if (BNLHIMHFGDK != other.BNLHIMHFGDK)
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
		if (NIECFPJPGOB != 0)
		{
			num ^= NIECFPJPGOB.GetHashCode();
		}
		if (AEILFKMAJGN != 0)
		{
			num ^= AEILFKMAJGN.GetHashCode();
		}
		if (BNLHIMHFGDK != 0)
		{
			num ^= BNLHIMHFGDK.GetHashCode();
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
		if (NIECFPJPGOB != 0)
		{
			output.WriteRawTag(24);
			output.WriteUInt32(NIECFPJPGOB);
		}
		if (AEILFKMAJGN != 0)
		{
			output.WriteRawTag(32);
			output.WriteUInt32(AEILFKMAJGN);
		}
		if (BNLHIMHFGDK != 0)
		{
			output.WriteRawTag(104);
			output.WriteUInt32(BNLHIMHFGDK);
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
		if (NIECFPJPGOB != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(NIECFPJPGOB);
		}
		if (AEILFKMAJGN != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(AEILFKMAJGN);
		}
		if (BNLHIMHFGDK != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(BNLHIMHFGDK);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(GEBNNLDNKGG other)
	{
		if (other != null)
		{
			if (other.NIECFPJPGOB != 0)
			{
				NIECFPJPGOB = other.NIECFPJPGOB;
			}
			if (other.AEILFKMAJGN != 0)
			{
				AEILFKMAJGN = other.AEILFKMAJGN;
			}
			if (other.BNLHIMHFGDK != 0)
			{
				BNLHIMHFGDK = other.BNLHIMHFGDK;
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
				NIECFPJPGOB = input.ReadUInt32();
				break;
			case 32u:
				AEILFKMAJGN = input.ReadUInt32();
				break;
			case 104u:
				BNLHIMHFGDK = input.ReadUInt32();
				break;
			}
		}
	}
}
