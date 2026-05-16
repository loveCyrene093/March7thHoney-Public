using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class MKPDCILELAA : IMessage<MKPDCILELAA>, IMessage, IEquatable<MKPDCILELAA>, IDeepCloneable<MKPDCILELAA>, IBufferMessage
{
	private static readonly MessageParser<MKPDCILELAA> _parser = new MessageParser<MKPDCILELAA>(() => new MKPDCILELAA());

	private UnknownFieldSet _unknownFields;

	public const int MDFOADMKJDLFieldNumber = 1;

	private uint mDFOADMKJDL_;

	public const int PDAIGDFNPPNFieldNumber = 10;

	private uint pDAIGDFNPPN_;

	public const int AOMDBDNMBFCFieldNumber = 14;

	private static readonly MapField<uint, uint>.Codec _map_aOMDBDNMBFC_codec = new MapField<uint, uint>.Codec(FieldCodec.ForUInt32(8u, 0u), FieldCodec.ForUInt32(16u, 0u), 114u);

	private readonly MapField<uint, uint> aOMDBDNMBFC_ = new MapField<uint, uint>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<MKPDCILELAA> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => MKPDCILELAAReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint MDFOADMKJDL
	{
		get
		{
			return mDFOADMKJDL_;
		}
		set
		{
			mDFOADMKJDL_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint PDAIGDFNPPN
	{
		get
		{
			return pDAIGDFNPPN_;
		}
		set
		{
			pDAIGDFNPPN_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MapField<uint, uint> AOMDBDNMBFC => aOMDBDNMBFC_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MKPDCILELAA()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MKPDCILELAA(MKPDCILELAA other)
		: this()
	{
		mDFOADMKJDL_ = other.mDFOADMKJDL_;
		pDAIGDFNPPN_ = other.pDAIGDFNPPN_;
		aOMDBDNMBFC_ = other.aOMDBDNMBFC_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MKPDCILELAA Clone()
	{
		return new MKPDCILELAA(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as MKPDCILELAA);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(MKPDCILELAA other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (MDFOADMKJDL != other.MDFOADMKJDL)
		{
			return false;
		}
		if (PDAIGDFNPPN != other.PDAIGDFNPPN)
		{
			return false;
		}
		if (!AOMDBDNMBFC.Equals(other.AOMDBDNMBFC))
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
		if (MDFOADMKJDL != 0)
		{
			num ^= MDFOADMKJDL.GetHashCode();
		}
		if (PDAIGDFNPPN != 0)
		{
			num ^= PDAIGDFNPPN.GetHashCode();
		}
		num ^= AOMDBDNMBFC.GetHashCode();
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
		if (MDFOADMKJDL != 0)
		{
			output.WriteRawTag(8);
			output.WriteUInt32(MDFOADMKJDL);
		}
		if (PDAIGDFNPPN != 0)
		{
			output.WriteRawTag(80);
			output.WriteUInt32(PDAIGDFNPPN);
		}
		aOMDBDNMBFC_.WriteTo(ref output, _map_aOMDBDNMBFC_codec);
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
		if (MDFOADMKJDL != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(MDFOADMKJDL);
		}
		if (PDAIGDFNPPN != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(PDAIGDFNPPN);
		}
		num += aOMDBDNMBFC_.CalculateSize(_map_aOMDBDNMBFC_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(MKPDCILELAA other)
	{
		if (other != null)
		{
			if (other.MDFOADMKJDL != 0)
			{
				MDFOADMKJDL = other.MDFOADMKJDL;
			}
			if (other.PDAIGDFNPPN != 0)
			{
				PDAIGDFNPPN = other.PDAIGDFNPPN;
			}
			aOMDBDNMBFC_.MergeFrom(other.aOMDBDNMBFC_);
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
				MDFOADMKJDL = input.ReadUInt32();
				break;
			case 80u:
				PDAIGDFNPPN = input.ReadUInt32();
				break;
			case 114u:
				aOMDBDNMBFC_.AddEntriesFrom(ref input, _map_aOMDBDNMBFC_codec);
				break;
			}
		}
	}
}
