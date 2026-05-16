using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class GJFAPKAGEED : IMessage<GJFAPKAGEED>, IMessage, IEquatable<GJFAPKAGEED>, IDeepCloneable<GJFAPKAGEED>, IBufferMessage
{
	private static readonly MessageParser<GJFAPKAGEED> _parser = new MessageParser<GJFAPKAGEED>(() => new GJFAPKAGEED());

	private UnknownFieldSet _unknownFields;

	public const int HBNHCEOKIBJFieldNumber = 3;

	private static readonly MapField<string, double>.Codec _map_hBNHCEOKIBJ_codec = new MapField<string, double>.Codec(FieldCodec.ForString(10u, ""), FieldCodec.ForDouble(17u, 0.0), 26u);

	private readonly MapField<string, double> hBNHCEOKIBJ_ = new MapField<string, double>();

	public const int MKHDINDGHMDFieldNumber = 6;

	private MMDNCMMOKPO mKHDINDGHMD_;

	public const int PNFBHHBLAFHFieldNumber = 11;

	private uint pNFBHHBLAFH_;

	public const int BAMNMENGKFGFieldNumber = 13;

	private uint bAMNMENGKFG_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<GJFAPKAGEED> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => GJFAPKAGEEDReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MapField<string, double> HBNHCEOKIBJ => hBNHCEOKIBJ_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MMDNCMMOKPO MKHDINDGHMD
	{
		get
		{
			return mKHDINDGHMD_;
		}
		set
		{
			mKHDINDGHMD_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint PNFBHHBLAFH
	{
		get
		{
			return pNFBHHBLAFH_;
		}
		set
		{
			pNFBHHBLAFH_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint BAMNMENGKFG
	{
		get
		{
			return bAMNMENGKFG_;
		}
		set
		{
			bAMNMENGKFG_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GJFAPKAGEED()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GJFAPKAGEED(GJFAPKAGEED other)
		: this()
	{
		hBNHCEOKIBJ_ = other.hBNHCEOKIBJ_.Clone();
		mKHDINDGHMD_ = other.mKHDINDGHMD_;
		pNFBHHBLAFH_ = other.pNFBHHBLAFH_;
		bAMNMENGKFG_ = other.bAMNMENGKFG_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GJFAPKAGEED Clone()
	{
		return new GJFAPKAGEED(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as GJFAPKAGEED);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(GJFAPKAGEED other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!HBNHCEOKIBJ.Equals(other.HBNHCEOKIBJ))
		{
			return false;
		}
		if (MKHDINDGHMD != other.MKHDINDGHMD)
		{
			return false;
		}
		if (PNFBHHBLAFH != other.PNFBHHBLAFH)
		{
			return false;
		}
		if (BAMNMENGKFG != other.BAMNMENGKFG)
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
		num ^= HBNHCEOKIBJ.GetHashCode();
		if (MKHDINDGHMD != MMDNCMMOKPO.Bbpaehefjhd)
		{
			num ^= MKHDINDGHMD.GetHashCode();
		}
		if (PNFBHHBLAFH != 0)
		{
			num ^= PNFBHHBLAFH.GetHashCode();
		}
		if (BAMNMENGKFG != 0)
		{
			num ^= BAMNMENGKFG.GetHashCode();
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
		hBNHCEOKIBJ_.WriteTo(ref output, _map_hBNHCEOKIBJ_codec);
		if (MKHDINDGHMD != MMDNCMMOKPO.Bbpaehefjhd)
		{
			output.WriteRawTag(48);
			output.WriteEnum((int)MKHDINDGHMD);
		}
		if (PNFBHHBLAFH != 0)
		{
			output.WriteRawTag(88);
			output.WriteUInt32(PNFBHHBLAFH);
		}
		if (BAMNMENGKFG != 0)
		{
			output.WriteRawTag(104);
			output.WriteUInt32(BAMNMENGKFG);
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
		num += hBNHCEOKIBJ_.CalculateSize(_map_hBNHCEOKIBJ_codec);
		if (MKHDINDGHMD != MMDNCMMOKPO.Bbpaehefjhd)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)MKHDINDGHMD);
		}
		if (PNFBHHBLAFH != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(PNFBHHBLAFH);
		}
		if (BAMNMENGKFG != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(BAMNMENGKFG);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(GJFAPKAGEED other)
	{
		if (other != null)
		{
			hBNHCEOKIBJ_.MergeFrom(other.hBNHCEOKIBJ_);
			if (other.MKHDINDGHMD != MMDNCMMOKPO.Bbpaehefjhd)
			{
				MKHDINDGHMD = other.MKHDINDGHMD;
			}
			if (other.PNFBHHBLAFH != 0)
			{
				PNFBHHBLAFH = other.PNFBHHBLAFH;
			}
			if (other.BAMNMENGKFG != 0)
			{
				BAMNMENGKFG = other.BAMNMENGKFG;
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
			case 26u:
				hBNHCEOKIBJ_.AddEntriesFrom(ref input, _map_hBNHCEOKIBJ_codec);
				break;
			case 48u:
				MKHDINDGHMD = (MMDNCMMOKPO)input.ReadEnum();
				break;
			case 88u:
				PNFBHHBLAFH = input.ReadUInt32();
				break;
			case 104u:
				BAMNMENGKFG = input.ReadUInt32();
				break;
			}
		}
	}
}
