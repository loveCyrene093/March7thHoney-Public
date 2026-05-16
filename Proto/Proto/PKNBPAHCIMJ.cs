using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class PKNBPAHCIMJ : IMessage<PKNBPAHCIMJ>, IMessage, IEquatable<PKNBPAHCIMJ>, IDeepCloneable<PKNBPAHCIMJ>, IBufferMessage
{
	private static readonly MessageParser<PKNBPAHCIMJ> _parser = new MessageParser<PKNBPAHCIMJ>(() => new PKNBPAHCIMJ());

	private UnknownFieldSet _unknownFields;

	public const int COKGOPBMLPPFieldNumber = 2;

	private uint cOKGOPBMLPP_;

	public const int HNENKAHDBKMFieldNumber = 5;

	private static readonly MapField<uint, uint>.Codec _map_hNENKAHDBKM_codec = new MapField<uint, uint>.Codec(FieldCodec.ForUInt32(8u, 0u), FieldCodec.ForUInt32(16u, 0u), 42u);

	private readonly MapField<uint, uint> hNENKAHDBKM_ = new MapField<uint, uint>();

	public const int PPOGPOJJELJFieldNumber = 12;

	private uint pPOGPOJJELJ_;

	public const int GLIONEELOJHFieldNumber = 13;

	private uint gLIONEELOJH_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<PKNBPAHCIMJ> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => PKNBPAHCIMJReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint COKGOPBMLPP
	{
		get
		{
			return cOKGOPBMLPP_;
		}
		set
		{
			cOKGOPBMLPP_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MapField<uint, uint> HNENKAHDBKM => hNENKAHDBKM_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint PPOGPOJJELJ
	{
		get
		{
			return pPOGPOJJELJ_;
		}
		set
		{
			pPOGPOJJELJ_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint GLIONEELOJH
	{
		get
		{
			return gLIONEELOJH_;
		}
		set
		{
			gLIONEELOJH_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PKNBPAHCIMJ()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PKNBPAHCIMJ(PKNBPAHCIMJ other)
		: this()
	{
		cOKGOPBMLPP_ = other.cOKGOPBMLPP_;
		hNENKAHDBKM_ = other.hNENKAHDBKM_.Clone();
		pPOGPOJJELJ_ = other.pPOGPOJJELJ_;
		gLIONEELOJH_ = other.gLIONEELOJH_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PKNBPAHCIMJ Clone()
	{
		return new PKNBPAHCIMJ(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as PKNBPAHCIMJ);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(PKNBPAHCIMJ other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (COKGOPBMLPP != other.COKGOPBMLPP)
		{
			return false;
		}
		if (!HNENKAHDBKM.Equals(other.HNENKAHDBKM))
		{
			return false;
		}
		if (PPOGPOJJELJ != other.PPOGPOJJELJ)
		{
			return false;
		}
		if (GLIONEELOJH != other.GLIONEELOJH)
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
		if (COKGOPBMLPP != 0)
		{
			num ^= COKGOPBMLPP.GetHashCode();
		}
		num ^= HNENKAHDBKM.GetHashCode();
		if (PPOGPOJJELJ != 0)
		{
			num ^= PPOGPOJJELJ.GetHashCode();
		}
		if (GLIONEELOJH != 0)
		{
			num ^= GLIONEELOJH.GetHashCode();
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
		if (COKGOPBMLPP != 0)
		{
			output.WriteRawTag(16);
			output.WriteUInt32(COKGOPBMLPP);
		}
		hNENKAHDBKM_.WriteTo(ref output, _map_hNENKAHDBKM_codec);
		if (PPOGPOJJELJ != 0)
		{
			output.WriteRawTag(96);
			output.WriteUInt32(PPOGPOJJELJ);
		}
		if (GLIONEELOJH != 0)
		{
			output.WriteRawTag(104);
			output.WriteUInt32(GLIONEELOJH);
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
		if (COKGOPBMLPP != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(COKGOPBMLPP);
		}
		num += hNENKAHDBKM_.CalculateSize(_map_hNENKAHDBKM_codec);
		if (PPOGPOJJELJ != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(PPOGPOJJELJ);
		}
		if (GLIONEELOJH != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(GLIONEELOJH);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(PKNBPAHCIMJ other)
	{
		if (other != null)
		{
			if (other.COKGOPBMLPP != 0)
			{
				COKGOPBMLPP = other.COKGOPBMLPP;
			}
			hNENKAHDBKM_.MergeFrom(other.hNENKAHDBKM_);
			if (other.PPOGPOJJELJ != 0)
			{
				PPOGPOJJELJ = other.PPOGPOJJELJ;
			}
			if (other.GLIONEELOJH != 0)
			{
				GLIONEELOJH = other.GLIONEELOJH;
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
				COKGOPBMLPP = input.ReadUInt32();
				break;
			case 42u:
				hNENKAHDBKM_.AddEntriesFrom(ref input, _map_hNENKAHDBKM_codec);
				break;
			case 96u:
				PPOGPOJJELJ = input.ReadUInt32();
				break;
			case 104u:
				GLIONEELOJH = input.ReadUInt32();
				break;
			}
		}
	}
}
