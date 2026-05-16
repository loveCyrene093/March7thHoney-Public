using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class NLJLHPEOIOC : IMessage<NLJLHPEOIOC>, IMessage, IEquatable<NLJLHPEOIOC>, IDeepCloneable<NLJLHPEOIOC>, IBufferMessage
{
	private static readonly MessageParser<NLJLHPEOIOC> _parser = new MessageParser<NLJLHPEOIOC>(() => new NLJLHPEOIOC());

	private UnknownFieldSet _unknownFields;

	public const int FCLBGGPJGCEFieldNumber = 2;

	private uint fCLBGGPJGCE_;

	public const int DDIDEEAKCPPFieldNumber = 3;

	private static readonly FieldCodec<uint> _repeated_dDIDEEAKCPP_codec = FieldCodec.ForUInt32(26u);

	private readonly RepeatedField<uint> dDIDEEAKCPP_ = new RepeatedField<uint>();

	public const int HAAAPFLGNBMFieldNumber = 6;

	private uint hAAAPFLGNBM_;

	public const int HNOFDLBBHHFFieldNumber = 8;

	private bool hNOFDLBBHHF_;

	public const int LKCCKBKNKBPFieldNumber = 12;

	private uint lKCCKBKNKBP_;

	public const int HJKAPBEMEOOFieldNumber = 15;

	private ulong hJKAPBEMEOO_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<NLJLHPEOIOC> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => NLJLHPEOIOCReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint FCLBGGPJGCE
	{
		get
		{
			return fCLBGGPJGCE_;
		}
		set
		{
			fCLBGGPJGCE_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> DDIDEEAKCPP => dDIDEEAKCPP_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint HAAAPFLGNBM
	{
		get
		{
			return hAAAPFLGNBM_;
		}
		set
		{
			hAAAPFLGNBM_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool HNOFDLBBHHF
	{
		get
		{
			return hNOFDLBBHHF_;
		}
		set
		{
			hNOFDLBBHHF_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint LKCCKBKNKBP
	{
		get
		{
			return lKCCKBKNKBP_;
		}
		set
		{
			lKCCKBKNKBP_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ulong HJKAPBEMEOO
	{
		get
		{
			return hJKAPBEMEOO_;
		}
		set
		{
			hJKAPBEMEOO_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public NLJLHPEOIOC()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public NLJLHPEOIOC(NLJLHPEOIOC other)
		: this()
	{
		fCLBGGPJGCE_ = other.fCLBGGPJGCE_;
		dDIDEEAKCPP_ = other.dDIDEEAKCPP_.Clone();
		hAAAPFLGNBM_ = other.hAAAPFLGNBM_;
		hNOFDLBBHHF_ = other.hNOFDLBBHHF_;
		lKCCKBKNKBP_ = other.lKCCKBKNKBP_;
		hJKAPBEMEOO_ = other.hJKAPBEMEOO_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public NLJLHPEOIOC Clone()
	{
		return new NLJLHPEOIOC(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as NLJLHPEOIOC);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(NLJLHPEOIOC other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (FCLBGGPJGCE != other.FCLBGGPJGCE)
		{
			return false;
		}
		if (!dDIDEEAKCPP_.Equals(other.dDIDEEAKCPP_))
		{
			return false;
		}
		if (HAAAPFLGNBM != other.HAAAPFLGNBM)
		{
			return false;
		}
		if (HNOFDLBBHHF != other.HNOFDLBBHHF)
		{
			return false;
		}
		if (LKCCKBKNKBP != other.LKCCKBKNKBP)
		{
			return false;
		}
		if (HJKAPBEMEOO != other.HJKAPBEMEOO)
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
		if (FCLBGGPJGCE != 0)
		{
			num ^= FCLBGGPJGCE.GetHashCode();
		}
		num ^= dDIDEEAKCPP_.GetHashCode();
		if (HAAAPFLGNBM != 0)
		{
			num ^= HAAAPFLGNBM.GetHashCode();
		}
		if (HNOFDLBBHHF)
		{
			num ^= HNOFDLBBHHF.GetHashCode();
		}
		if (LKCCKBKNKBP != 0)
		{
			num ^= LKCCKBKNKBP.GetHashCode();
		}
		if (HJKAPBEMEOO != 0L)
		{
			num ^= HJKAPBEMEOO.GetHashCode();
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
		if (FCLBGGPJGCE != 0)
		{
			output.WriteRawTag(16);
			output.WriteUInt32(FCLBGGPJGCE);
		}
		dDIDEEAKCPP_.WriteTo(ref output, _repeated_dDIDEEAKCPP_codec);
		if (HAAAPFLGNBM != 0)
		{
			output.WriteRawTag(48);
			output.WriteUInt32(HAAAPFLGNBM);
		}
		if (HNOFDLBBHHF)
		{
			output.WriteRawTag(64);
			output.WriteBool(HNOFDLBBHHF);
		}
		if (LKCCKBKNKBP != 0)
		{
			output.WriteRawTag(96);
			output.WriteUInt32(LKCCKBKNKBP);
		}
		if (HJKAPBEMEOO != 0L)
		{
			output.WriteRawTag(120);
			output.WriteUInt64(HJKAPBEMEOO);
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
		if (FCLBGGPJGCE != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(FCLBGGPJGCE);
		}
		num += dDIDEEAKCPP_.CalculateSize(_repeated_dDIDEEAKCPP_codec);
		if (HAAAPFLGNBM != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(HAAAPFLGNBM);
		}
		if (HNOFDLBBHHF)
		{
			num += 2;
		}
		if (LKCCKBKNKBP != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(LKCCKBKNKBP);
		}
		if (HJKAPBEMEOO != 0L)
		{
			num += 1 + CodedOutputStream.ComputeUInt64Size(HJKAPBEMEOO);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(NLJLHPEOIOC other)
	{
		if (other != null)
		{
			if (other.FCLBGGPJGCE != 0)
			{
				FCLBGGPJGCE = other.FCLBGGPJGCE;
			}
			dDIDEEAKCPP_.Add(other.dDIDEEAKCPP_);
			if (other.HAAAPFLGNBM != 0)
			{
				HAAAPFLGNBM = other.HAAAPFLGNBM;
			}
			if (other.HNOFDLBBHHF)
			{
				HNOFDLBBHHF = other.HNOFDLBBHHF;
			}
			if (other.LKCCKBKNKBP != 0)
			{
				LKCCKBKNKBP = other.LKCCKBKNKBP;
			}
			if (other.HJKAPBEMEOO != 0L)
			{
				HJKAPBEMEOO = other.HJKAPBEMEOO;
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
				FCLBGGPJGCE = input.ReadUInt32();
				break;
			case 24u:
			case 26u:
				dDIDEEAKCPP_.AddEntriesFrom(ref input, _repeated_dDIDEEAKCPP_codec);
				break;
			case 48u:
				HAAAPFLGNBM = input.ReadUInt32();
				break;
			case 64u:
				HNOFDLBBHHF = input.ReadBool();
				break;
			case 96u:
				LKCCKBKNKBP = input.ReadUInt32();
				break;
			case 120u:
				HJKAPBEMEOO = input.ReadUInt64();
				break;
			}
		}
	}
}
