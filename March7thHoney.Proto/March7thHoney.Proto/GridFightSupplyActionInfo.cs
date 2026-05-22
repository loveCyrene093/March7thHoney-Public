using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class GridFightSupplyActionInfo : IMessage<GridFightSupplyActionInfo>, IMessage, IEquatable<GridFightSupplyActionInfo>, IDeepCloneable<GridFightSupplyActionInfo>, IBufferMessage
{
	private static readonly MessageParser<GridFightSupplyActionInfo> _parser = new MessageParser<GridFightSupplyActionInfo>(() => new GridFightSupplyActionInfo());

	private UnknownFieldSet _unknownFields;

	public const int SupplyRoleInfoListFieldNumber = 2;

	private static readonly FieldCodec<GridFightSupplyRoleInfo> _repeated_supplyRoleInfoList_codec = FieldCodec.ForMessage(18u, GridFightSupplyRoleInfo.Parser);

	private readonly RepeatedField<GridFightSupplyRoleInfo> supplyRoleInfoList_ = new RepeatedField<GridFightSupplyRoleInfo>();

	public const int EOOPOFCCHAAFieldNumber = 5;

	private uint eOOPOFCCHAA_;

	public const int CGFLMCHMBHLFieldNumber = 6;

	private uint cGFLMCHMBHL_;

	public const int FCHPJKAIBHBFieldNumber = 11;

	private uint fCHPJKAIBHB_;

	public const int PDFICBIMHJMFieldNumber = 13;

	private uint pDFICBIMHJM_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<GridFightSupplyActionInfo> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => GridFightSupplyActionInfoReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<GridFightSupplyRoleInfo> SupplyRoleInfoList => supplyRoleInfoList_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint EOOPOFCCHAA
	{
		get
		{
			return eOOPOFCCHAA_;
		}
		set
		{
			eOOPOFCCHAA_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint CGFLMCHMBHL
	{
		get
		{
			return cGFLMCHMBHL_;
		}
		set
		{
			cGFLMCHMBHL_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint FCHPJKAIBHB
	{
		get
		{
			return fCHPJKAIBHB_;
		}
		set
		{
			fCHPJKAIBHB_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint PDFICBIMHJM
	{
		get
		{
			return pDFICBIMHJM_;
		}
		set
		{
			pDFICBIMHJM_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GridFightSupplyActionInfo()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GridFightSupplyActionInfo(GridFightSupplyActionInfo other)
		: this()
	{
		supplyRoleInfoList_ = other.supplyRoleInfoList_.Clone();
		eOOPOFCCHAA_ = other.eOOPOFCCHAA_;
		cGFLMCHMBHL_ = other.cGFLMCHMBHL_;
		fCHPJKAIBHB_ = other.fCHPJKAIBHB_;
		pDFICBIMHJM_ = other.pDFICBIMHJM_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GridFightSupplyActionInfo Clone()
	{
		return new GridFightSupplyActionInfo(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as GridFightSupplyActionInfo);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(GridFightSupplyActionInfo other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!supplyRoleInfoList_.Equals(other.supplyRoleInfoList_))
		{
			return false;
		}
		if (EOOPOFCCHAA != other.EOOPOFCCHAA)
		{
			return false;
		}
		if (CGFLMCHMBHL != other.CGFLMCHMBHL)
		{
			return false;
		}
		if (FCHPJKAIBHB != other.FCHPJKAIBHB)
		{
			return false;
		}
		if (PDFICBIMHJM != other.PDFICBIMHJM)
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
		num ^= supplyRoleInfoList_.GetHashCode();
		if (EOOPOFCCHAA != 0)
		{
			num ^= EOOPOFCCHAA.GetHashCode();
		}
		if (CGFLMCHMBHL != 0)
		{
			num ^= CGFLMCHMBHL.GetHashCode();
		}
		if (FCHPJKAIBHB != 0)
		{
			num ^= FCHPJKAIBHB.GetHashCode();
		}
		if (PDFICBIMHJM != 0)
		{
			num ^= PDFICBIMHJM.GetHashCode();
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
		supplyRoleInfoList_.WriteTo(ref output, _repeated_supplyRoleInfoList_codec);
		if (EOOPOFCCHAA != 0)
		{
			output.WriteRawTag(40);
			output.WriteUInt32(EOOPOFCCHAA);
		}
		if (CGFLMCHMBHL != 0)
		{
			output.WriteRawTag(48);
			output.WriteUInt32(CGFLMCHMBHL);
		}
		if (FCHPJKAIBHB != 0)
		{
			output.WriteRawTag(88);
			output.WriteUInt32(FCHPJKAIBHB);
		}
		if (PDFICBIMHJM != 0)
		{
			output.WriteRawTag(104);
			output.WriteUInt32(PDFICBIMHJM);
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
		num += supplyRoleInfoList_.CalculateSize(_repeated_supplyRoleInfoList_codec);
		if (EOOPOFCCHAA != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(EOOPOFCCHAA);
		}
		if (CGFLMCHMBHL != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(CGFLMCHMBHL);
		}
		if (FCHPJKAIBHB != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(FCHPJKAIBHB);
		}
		if (PDFICBIMHJM != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(PDFICBIMHJM);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(GridFightSupplyActionInfo other)
	{
		if (other != null)
		{
			supplyRoleInfoList_.Add(other.supplyRoleInfoList_);
			if (other.EOOPOFCCHAA != 0)
			{
				EOOPOFCCHAA = other.EOOPOFCCHAA;
			}
			if (other.CGFLMCHMBHL != 0)
			{
				CGFLMCHMBHL = other.CGFLMCHMBHL;
			}
			if (other.FCHPJKAIBHB != 0)
			{
				FCHPJKAIBHB = other.FCHPJKAIBHB;
			}
			if (other.PDFICBIMHJM != 0)
			{
				PDFICBIMHJM = other.PDFICBIMHJM;
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
			case 18u:
				supplyRoleInfoList_.AddEntriesFrom(ref input, _repeated_supplyRoleInfoList_codec);
				break;
			case 40u:
				EOOPOFCCHAA = input.ReadUInt32();
				break;
			case 48u:
				CGFLMCHMBHL = input.ReadUInt32();
				break;
			case 88u:
				FCHPJKAIBHB = input.ReadUInt32();
				break;
			case 104u:
				PDFICBIMHJM = input.ReadUInt32();
				break;
			}
		}
	}
}
