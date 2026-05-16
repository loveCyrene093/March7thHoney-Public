using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class CMJBMFHCOFI : IMessage<CMJBMFHCOFI>, IMessage, IEquatable<CMJBMFHCOFI>, IDeepCloneable<CMJBMFHCOFI>, IBufferMessage
{
	private static readonly MessageParser<CMJBMFHCOFI> _parser = new MessageParser<CMJBMFHCOFI>(() => new CMJBMFHCOFI());

	private UnknownFieldSet _unknownFields;

	public const int HJMGGLANHMLFieldNumber = 1;

	private uint hJMGGLANHML_;

	public const int MonsterIdFieldNumber = 2;

	private uint monsterId_;

	public const int PECILINELNGFieldNumber = 3;

	private static readonly FieldCodec<ANHLFCJGPEE> _repeated_pECILINELNG_codec = FieldCodec.ForMessage(26u, ANHLFCJGPEE.Parser);

	private readonly RepeatedField<ANHLFCJGPEE> pECILINELNG_ = new RepeatedField<ANHLFCJGPEE>();

	public const int JHFKANKGLJNFieldNumber = 4;

	private uint jHFKANKGLJN_;

	public const int NKBAPJPHJFPFieldNumber = 5;

	private static readonly FieldCodec<PGOGPOHEIEG> _repeated_nKBAPJPHJFP_codec = FieldCodec.ForMessage(42u, PGOGPOHEIEG.Parser);

	private readonly RepeatedField<PGOGPOHEIEG> nKBAPJPHJFP_ = new RepeatedField<PGOGPOHEIEG>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<CMJBMFHCOFI> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => CMJBMFHCOFIReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint HJMGGLANHML
	{
		get
		{
			return hJMGGLANHML_;
		}
		set
		{
			hJMGGLANHML_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint MonsterId
	{
		get
		{
			return monsterId_;
		}
		set
		{
			monsterId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<ANHLFCJGPEE> PECILINELNG => pECILINELNG_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint JHFKANKGLJN
	{
		get
		{
			return jHFKANKGLJN_;
		}
		set
		{
			jHFKANKGLJN_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<PGOGPOHEIEG> NKBAPJPHJFP => nKBAPJPHJFP_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CMJBMFHCOFI()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CMJBMFHCOFI(CMJBMFHCOFI other)
		: this()
	{
		hJMGGLANHML_ = other.hJMGGLANHML_;
		monsterId_ = other.monsterId_;
		pECILINELNG_ = other.pECILINELNG_.Clone();
		jHFKANKGLJN_ = other.jHFKANKGLJN_;
		nKBAPJPHJFP_ = other.nKBAPJPHJFP_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CMJBMFHCOFI Clone()
	{
		return new CMJBMFHCOFI(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as CMJBMFHCOFI);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(CMJBMFHCOFI other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (HJMGGLANHML != other.HJMGGLANHML)
		{
			return false;
		}
		if (MonsterId != other.MonsterId)
		{
			return false;
		}
		if (!pECILINELNG_.Equals(other.pECILINELNG_))
		{
			return false;
		}
		if (JHFKANKGLJN != other.JHFKANKGLJN)
		{
			return false;
		}
		if (!nKBAPJPHJFP_.Equals(other.nKBAPJPHJFP_))
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
		if (HJMGGLANHML != 0)
		{
			num ^= HJMGGLANHML.GetHashCode();
		}
		if (MonsterId != 0)
		{
			num ^= MonsterId.GetHashCode();
		}
		num ^= pECILINELNG_.GetHashCode();
		if (JHFKANKGLJN != 0)
		{
			num ^= JHFKANKGLJN.GetHashCode();
		}
		num ^= nKBAPJPHJFP_.GetHashCode();
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
		if (HJMGGLANHML != 0)
		{
			output.WriteRawTag(8);
			output.WriteUInt32(HJMGGLANHML);
		}
		if (MonsterId != 0)
		{
			output.WriteRawTag(16);
			output.WriteUInt32(MonsterId);
		}
		pECILINELNG_.WriteTo(ref output, _repeated_pECILINELNG_codec);
		if (JHFKANKGLJN != 0)
		{
			output.WriteRawTag(32);
			output.WriteUInt32(JHFKANKGLJN);
		}
		nKBAPJPHJFP_.WriteTo(ref output, _repeated_nKBAPJPHJFP_codec);
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
		if (HJMGGLANHML != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(HJMGGLANHML);
		}
		if (MonsterId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(MonsterId);
		}
		num += pECILINELNG_.CalculateSize(_repeated_pECILINELNG_codec);
		if (JHFKANKGLJN != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(JHFKANKGLJN);
		}
		num += nKBAPJPHJFP_.CalculateSize(_repeated_nKBAPJPHJFP_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CMJBMFHCOFI other)
	{
		if (other != null)
		{
			if (other.HJMGGLANHML != 0)
			{
				HJMGGLANHML = other.HJMGGLANHML;
			}
			if (other.MonsterId != 0)
			{
				MonsterId = other.MonsterId;
			}
			pECILINELNG_.Add(other.pECILINELNG_);
			if (other.JHFKANKGLJN != 0)
			{
				JHFKANKGLJN = other.JHFKANKGLJN;
			}
			nKBAPJPHJFP_.Add(other.nKBAPJPHJFP_);
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
				HJMGGLANHML = input.ReadUInt32();
				break;
			case 16u:
				MonsterId = input.ReadUInt32();
				break;
			case 26u:
				pECILINELNG_.AddEntriesFrom(ref input, _repeated_pECILINELNG_codec);
				break;
			case 32u:
				JHFKANKGLJN = input.ReadUInt32();
				break;
			case 42u:
				nKBAPJPHJFP_.AddEntriesFrom(ref input, _repeated_nKBAPJPHJFP_codec);
				break;
			}
		}
	}
}
