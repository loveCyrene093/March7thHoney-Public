using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class BHMJAJGOJPM : IMessage<BHMJAJGOJPM>, IMessage, IEquatable<BHMJAJGOJPM>, IDeepCloneable<BHMJAJGOJPM>, IBufferMessage
{
	private static readonly MessageParser<BHMJAJGOJPM> _parser = new MessageParser<BHMJAJGOJPM>(() => new BHMJAJGOJPM());

	private UnknownFieldSet _unknownFields;

	public const int KKLHGCJKPLJFieldNumber = 3;

	private HHAANBNCLHI kKLHGCJKPLJ_;

	public const int HHDLEADBJGNFieldNumber = 6;

	private AHOLOHCLLKD hHDLEADBJGN_;

	public const int LBNHKPPAJIMFieldNumber = 10;

	private LineupInfo lBNHKPPAJIM_;

	public const int NOCNEOMKFIOFieldNumber = 15;

	private IGJJFOKAHAP nOCNEOMKFIO_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<BHMJAJGOJPM> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => BHMJAJGOJPMReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HHAANBNCLHI KKLHGCJKPLJ
	{
		get
		{
			return kKLHGCJKPLJ_;
		}
		set
		{
			kKLHGCJKPLJ_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AHOLOHCLLKD HHDLEADBJGN
	{
		get
		{
			return hHDLEADBJGN_;
		}
		set
		{
			hHDLEADBJGN_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public LineupInfo LBNHKPPAJIM
	{
		get
		{
			return lBNHKPPAJIM_;
		}
		set
		{
			lBNHKPPAJIM_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public IGJJFOKAHAP NOCNEOMKFIO
	{
		get
		{
			return nOCNEOMKFIO_;
		}
		set
		{
			nOCNEOMKFIO_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BHMJAJGOJPM()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BHMJAJGOJPM(BHMJAJGOJPM other)
		: this()
	{
		kKLHGCJKPLJ_ = ((other.kKLHGCJKPLJ_ != null) ? other.kKLHGCJKPLJ_.Clone() : null);
		hHDLEADBJGN_ = ((other.hHDLEADBJGN_ != null) ? other.hHDLEADBJGN_.Clone() : null);
		lBNHKPPAJIM_ = ((other.lBNHKPPAJIM_ != null) ? other.lBNHKPPAJIM_.Clone() : null);
		nOCNEOMKFIO_ = ((other.nOCNEOMKFIO_ != null) ? other.nOCNEOMKFIO_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BHMJAJGOJPM Clone()
	{
		return new BHMJAJGOJPM(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as BHMJAJGOJPM);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(BHMJAJGOJPM other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(KKLHGCJKPLJ, other.KKLHGCJKPLJ))
		{
			return false;
		}
		if (!object.Equals(HHDLEADBJGN, other.HHDLEADBJGN))
		{
			return false;
		}
		if (!object.Equals(LBNHKPPAJIM, other.LBNHKPPAJIM))
		{
			return false;
		}
		if (!object.Equals(NOCNEOMKFIO, other.NOCNEOMKFIO))
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
		if (kKLHGCJKPLJ_ != null)
		{
			num ^= KKLHGCJKPLJ.GetHashCode();
		}
		if (hHDLEADBJGN_ != null)
		{
			num ^= HHDLEADBJGN.GetHashCode();
		}
		if (lBNHKPPAJIM_ != null)
		{
			num ^= LBNHKPPAJIM.GetHashCode();
		}
		if (nOCNEOMKFIO_ != null)
		{
			num ^= NOCNEOMKFIO.GetHashCode();
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
		if (kKLHGCJKPLJ_ != null)
		{
			output.WriteRawTag(26);
			output.WriteMessage(KKLHGCJKPLJ);
		}
		if (hHDLEADBJGN_ != null)
		{
			output.WriteRawTag(50);
			output.WriteMessage(HHDLEADBJGN);
		}
		if (lBNHKPPAJIM_ != null)
		{
			output.WriteRawTag(82);
			output.WriteMessage(LBNHKPPAJIM);
		}
		if (nOCNEOMKFIO_ != null)
		{
			output.WriteRawTag(122);
			output.WriteMessage(NOCNEOMKFIO);
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
		if (kKLHGCJKPLJ_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(KKLHGCJKPLJ);
		}
		if (hHDLEADBJGN_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(HHDLEADBJGN);
		}
		if (lBNHKPPAJIM_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(LBNHKPPAJIM);
		}
		if (nOCNEOMKFIO_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(NOCNEOMKFIO);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(BHMJAJGOJPM other)
	{
		if (other == null)
		{
			return;
		}
		if (other.kKLHGCJKPLJ_ != null)
		{
			if (kKLHGCJKPLJ_ == null)
			{
				KKLHGCJKPLJ = new HHAANBNCLHI();
			}
			KKLHGCJKPLJ.MergeFrom(other.KKLHGCJKPLJ);
		}
		if (other.hHDLEADBJGN_ != null)
		{
			if (hHDLEADBJGN_ == null)
			{
				HHDLEADBJGN = new AHOLOHCLLKD();
			}
			HHDLEADBJGN.MergeFrom(other.HHDLEADBJGN);
		}
		if (other.lBNHKPPAJIM_ != null)
		{
			if (lBNHKPPAJIM_ == null)
			{
				LBNHKPPAJIM = new LineupInfo();
			}
			LBNHKPPAJIM.MergeFrom(other.LBNHKPPAJIM);
		}
		if (other.nOCNEOMKFIO_ != null)
		{
			if (nOCNEOMKFIO_ == null)
			{
				NOCNEOMKFIO = new IGJJFOKAHAP();
			}
			NOCNEOMKFIO.MergeFrom(other.NOCNEOMKFIO);
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
			case 26u:
				if (kKLHGCJKPLJ_ == null)
				{
					KKLHGCJKPLJ = new HHAANBNCLHI();
				}
				input.ReadMessage(KKLHGCJKPLJ);
				break;
			case 50u:
				if (hHDLEADBJGN_ == null)
				{
					HHDLEADBJGN = new AHOLOHCLLKD();
				}
				input.ReadMessage(HHDLEADBJGN);
				break;
			case 82u:
				if (lBNHKPPAJIM_ == null)
				{
					LBNHKPPAJIM = new LineupInfo();
				}
				input.ReadMessage(LBNHKPPAJIM);
				break;
			case 122u:
				if (nOCNEOMKFIO_ == null)
				{
					NOCNEOMKFIO = new IGJJFOKAHAP();
				}
				input.ReadMessage(NOCNEOMKFIO);
				break;
			}
		}
	}
}
