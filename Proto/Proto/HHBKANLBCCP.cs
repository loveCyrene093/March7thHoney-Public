using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class HHBKANLBCCP : IMessage<HHBKANLBCCP>, IMessage, IEquatable<HHBKANLBCCP>, IDeepCloneable<HHBKANLBCCP>, IBufferMessage
{
	private static readonly MessageParser<HHBKANLBCCP> _parser = new MessageParser<HHBKANLBCCP>(() => new HHBKANLBCCP());

	private UnknownFieldSet _unknownFields;

	public const int LevelFieldNumber = 1;

	private uint level_;

	public const int MPGFGKDBAHNFieldNumber = 2;

	private bool mPGFGKDBAHN_;

	public const int CIGFOLLCKKIFieldNumber = 3;

	private static readonly FieldCodec<IFDJPDIKLDI> _repeated_cIGFOLLCKKI_codec = FieldCodec.ForMessage(26u, IFDJPDIKLDI.Parser);

	private readonly RepeatedField<IFDJPDIKLDI> cIGFOLLCKKI_ = new RepeatedField<IFDJPDIKLDI>();

	public const int EFLLPPLCKBBFieldNumber = 6;

	private ulong eFLLPPLCKBB_;

	public const int MOOOPAMBOFKFieldNumber = 8;

	private uint mOOOPAMBOFK_;

	public const int GEFGOIGJHFJFieldNumber = 12;

	private ulong gEFGOIGJHFJ_;

	public const int FBHGPPCKEICFieldNumber = 15;

	private static readonly FieldCodec<IPHFDELCNBD> _repeated_fBHGPPCKEIC_codec = FieldCodec.ForMessage(122u, IPHFDELCNBD.Parser);

	private readonly RepeatedField<IPHFDELCNBD> fBHGPPCKEIC_ = new RepeatedField<IPHFDELCNBD>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<HHBKANLBCCP> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => HHBKANLBCCPReflection.Descriptor.MessageTypes[0];

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
	public bool MPGFGKDBAHN
	{
		get
		{
			return mPGFGKDBAHN_;
		}
		set
		{
			mPGFGKDBAHN_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<IFDJPDIKLDI> CIGFOLLCKKI => cIGFOLLCKKI_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ulong EFLLPPLCKBB
	{
		get
		{
			return eFLLPPLCKBB_;
		}
		set
		{
			eFLLPPLCKBB_ = value;
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
	public RepeatedField<IPHFDELCNBD> FBHGPPCKEIC => fBHGPPCKEIC_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HHBKANLBCCP()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HHBKANLBCCP(HHBKANLBCCP other)
		: this()
	{
		level_ = other.level_;
		mPGFGKDBAHN_ = other.mPGFGKDBAHN_;
		cIGFOLLCKKI_ = other.cIGFOLLCKKI_.Clone();
		eFLLPPLCKBB_ = other.eFLLPPLCKBB_;
		mOOOPAMBOFK_ = other.mOOOPAMBOFK_;
		gEFGOIGJHFJ_ = other.gEFGOIGJHFJ_;
		fBHGPPCKEIC_ = other.fBHGPPCKEIC_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HHBKANLBCCP Clone()
	{
		return new HHBKANLBCCP(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as HHBKANLBCCP);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(HHBKANLBCCP other)
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
		if (MPGFGKDBAHN != other.MPGFGKDBAHN)
		{
			return false;
		}
		if (!cIGFOLLCKKI_.Equals(other.cIGFOLLCKKI_))
		{
			return false;
		}
		if (EFLLPPLCKBB != other.EFLLPPLCKBB)
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
		if (!fBHGPPCKEIC_.Equals(other.fBHGPPCKEIC_))
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
		if (MPGFGKDBAHN)
		{
			num ^= MPGFGKDBAHN.GetHashCode();
		}
		num ^= cIGFOLLCKKI_.GetHashCode();
		if (EFLLPPLCKBB != 0L)
		{
			num ^= EFLLPPLCKBB.GetHashCode();
		}
		if (MOOOPAMBOFK != 0)
		{
			num ^= MOOOPAMBOFK.GetHashCode();
		}
		if (GEFGOIGJHFJ != 0L)
		{
			num ^= GEFGOIGJHFJ.GetHashCode();
		}
		num ^= fBHGPPCKEIC_.GetHashCode();
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
			output.WriteRawTag(8);
			output.WriteUInt32(Level);
		}
		if (MPGFGKDBAHN)
		{
			output.WriteRawTag(16);
			output.WriteBool(MPGFGKDBAHN);
		}
		cIGFOLLCKKI_.WriteTo(ref output, _repeated_cIGFOLLCKKI_codec);
		if (EFLLPPLCKBB != 0L)
		{
			output.WriteRawTag(48);
			output.WriteUInt64(EFLLPPLCKBB);
		}
		if (MOOOPAMBOFK != 0)
		{
			output.WriteRawTag(64);
			output.WriteUInt32(MOOOPAMBOFK);
		}
		if (GEFGOIGJHFJ != 0L)
		{
			output.WriteRawTag(96);
			output.WriteUInt64(GEFGOIGJHFJ);
		}
		fBHGPPCKEIC_.WriteTo(ref output, _repeated_fBHGPPCKEIC_codec);
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
		if (MPGFGKDBAHN)
		{
			num += 2;
		}
		num += cIGFOLLCKKI_.CalculateSize(_repeated_cIGFOLLCKKI_codec);
		if (EFLLPPLCKBB != 0L)
		{
			num += 1 + CodedOutputStream.ComputeUInt64Size(EFLLPPLCKBB);
		}
		if (MOOOPAMBOFK != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(MOOOPAMBOFK);
		}
		if (GEFGOIGJHFJ != 0L)
		{
			num += 1 + CodedOutputStream.ComputeUInt64Size(GEFGOIGJHFJ);
		}
		num += fBHGPPCKEIC_.CalculateSize(_repeated_fBHGPPCKEIC_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(HHBKANLBCCP other)
	{
		if (other != null)
		{
			if (other.Level != 0)
			{
				Level = other.Level;
			}
			if (other.MPGFGKDBAHN)
			{
				MPGFGKDBAHN = other.MPGFGKDBAHN;
			}
			cIGFOLLCKKI_.Add(other.cIGFOLLCKKI_);
			if (other.EFLLPPLCKBB != 0L)
			{
				EFLLPPLCKBB = other.EFLLPPLCKBB;
			}
			if (other.MOOOPAMBOFK != 0)
			{
				MOOOPAMBOFK = other.MOOOPAMBOFK;
			}
			if (other.GEFGOIGJHFJ != 0L)
			{
				GEFGOIGJHFJ = other.GEFGOIGJHFJ;
			}
			fBHGPPCKEIC_.Add(other.fBHGPPCKEIC_);
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
				Level = input.ReadUInt32();
				break;
			case 16u:
				MPGFGKDBAHN = input.ReadBool();
				break;
			case 26u:
				cIGFOLLCKKI_.AddEntriesFrom(ref input, _repeated_cIGFOLLCKKI_codec);
				break;
			case 48u:
				EFLLPPLCKBB = input.ReadUInt64();
				break;
			case 64u:
				MOOOPAMBOFK = input.ReadUInt32();
				break;
			case 96u:
				GEFGOIGJHFJ = input.ReadUInt64();
				break;
			case 122u:
				fBHGPPCKEIC_.AddEntriesFrom(ref input, _repeated_fBHGPPCKEIC_codec);
				break;
			}
		}
	}
}
