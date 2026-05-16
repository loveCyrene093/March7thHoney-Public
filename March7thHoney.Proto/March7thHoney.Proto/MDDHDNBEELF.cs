using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class MDDHDNBEELF : IMessage<MDDHDNBEELF>, IMessage, IEquatable<MDDHDNBEELF>, IDeepCloneable<MDDHDNBEELF>, IBufferMessage
{
	private static readonly MessageParser<MDDHDNBEELF> _parser = new MessageParser<MDDHDNBEELF>(() => new MDDHDNBEELF());

	private UnknownFieldSet _unknownFields;

	public const int DOAOPBBIGPOFieldNumber = 1;

	private uint dOAOPBBIGPO_;

	public const int BICPNKOCHGNFieldNumber = 2;

	private static readonly FieldCodec<ODOFBIJJNJG> _repeated_bICPNKOCHGN_codec = FieldCodec.ForMessage(18u, ODOFBIJJNJG.Parser);

	private readonly RepeatedField<ODOFBIJJNJG> bICPNKOCHGN_ = new RepeatedField<ODOFBIJJNJG>();

	public const int LevelFieldNumber = 3;

	private uint level_;

	public const int NMHNGINKOKNFieldNumber = 4;

	private static readonly MapField<uint, uint>.Codec _map_nMHNGINKOKN_codec = new MapField<uint, uint>.Codec(FieldCodec.ForUInt32(8u, 0u), FieldCodec.ForUInt32(16u, 0u), 34u);

	private readonly MapField<uint, uint> nMHNGINKOKN_ = new MapField<uint, uint>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<MDDHDNBEELF> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => MDDHDNBEELFReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint DOAOPBBIGPO
	{
		get
		{
			return dOAOPBBIGPO_;
		}
		set
		{
			dOAOPBBIGPO_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<ODOFBIJJNJG> BICPNKOCHGN => bICPNKOCHGN_;

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
	public MapField<uint, uint> NMHNGINKOKN => nMHNGINKOKN_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MDDHDNBEELF()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MDDHDNBEELF(MDDHDNBEELF other)
		: this()
	{
		dOAOPBBIGPO_ = other.dOAOPBBIGPO_;
		bICPNKOCHGN_ = other.bICPNKOCHGN_.Clone();
		level_ = other.level_;
		nMHNGINKOKN_ = other.nMHNGINKOKN_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MDDHDNBEELF Clone()
	{
		return new MDDHDNBEELF(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as MDDHDNBEELF);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(MDDHDNBEELF other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (DOAOPBBIGPO != other.DOAOPBBIGPO)
		{
			return false;
		}
		if (!bICPNKOCHGN_.Equals(other.bICPNKOCHGN_))
		{
			return false;
		}
		if (Level != other.Level)
		{
			return false;
		}
		if (!NMHNGINKOKN.Equals(other.NMHNGINKOKN))
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
		if (DOAOPBBIGPO != 0)
		{
			num ^= DOAOPBBIGPO.GetHashCode();
		}
		num ^= bICPNKOCHGN_.GetHashCode();
		if (Level != 0)
		{
			num ^= Level.GetHashCode();
		}
		num ^= NMHNGINKOKN.GetHashCode();
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
		if (DOAOPBBIGPO != 0)
		{
			output.WriteRawTag(8);
			output.WriteUInt32(DOAOPBBIGPO);
		}
		bICPNKOCHGN_.WriteTo(ref output, _repeated_bICPNKOCHGN_codec);
		if (Level != 0)
		{
			output.WriteRawTag(24);
			output.WriteUInt32(Level);
		}
		nMHNGINKOKN_.WriteTo(ref output, _map_nMHNGINKOKN_codec);
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
		if (DOAOPBBIGPO != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(DOAOPBBIGPO);
		}
		num += bICPNKOCHGN_.CalculateSize(_repeated_bICPNKOCHGN_codec);
		if (Level != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Level);
		}
		num += nMHNGINKOKN_.CalculateSize(_map_nMHNGINKOKN_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(MDDHDNBEELF other)
	{
		if (other != null)
		{
			if (other.DOAOPBBIGPO != 0)
			{
				DOAOPBBIGPO = other.DOAOPBBIGPO;
			}
			bICPNKOCHGN_.Add(other.bICPNKOCHGN_);
			if (other.Level != 0)
			{
				Level = other.Level;
			}
			nMHNGINKOKN_.MergeFrom(other.nMHNGINKOKN_);
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
				DOAOPBBIGPO = input.ReadUInt32();
				break;
			case 18u:
				bICPNKOCHGN_.AddEntriesFrom(ref input, _repeated_bICPNKOCHGN_codec);
				break;
			case 24u:
				Level = input.ReadUInt32();
				break;
			case 34u:
				nMHNGINKOKN_.AddEntriesFrom(ref input, _map_nMHNGINKOKN_codec);
				break;
			}
		}
	}
}
