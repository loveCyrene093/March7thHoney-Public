using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class AEOEFOILEBP : IMessage<AEOEFOILEBP>, IMessage, IEquatable<AEOEFOILEBP>, IDeepCloneable<AEOEFOILEBP>, IBufferMessage
{
	private static readonly MessageParser<AEOEFOILEBP> _parser = new MessageParser<AEOEFOILEBP>(() => new AEOEFOILEBP());

	private UnknownFieldSet _unknownFields;

	public const int DACOKFCBMBIFieldNumber = 1;

	private uint dACOKFCBMBI_;

	public const int BGADLDEHIIBFieldNumber = 6;

	private uint bGADLDEHIIB_;

	public const int PanelIdFieldNumber = 8;

	private uint panelId_;

	public const int CFOFOCKJGCGFieldNumber = 12;

	private uint cFOFOCKJGCG_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<AEOEFOILEBP> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => AEOEFOILEBPReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint DACOKFCBMBI
	{
		get
		{
			return dACOKFCBMBI_;
		}
		set
		{
			dACOKFCBMBI_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint BGADLDEHIIB
	{
		get
		{
			return bGADLDEHIIB_;
		}
		set
		{
			bGADLDEHIIB_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint PanelId
	{
		get
		{
			return panelId_;
		}
		set
		{
			panelId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint CFOFOCKJGCG
	{
		get
		{
			return cFOFOCKJGCG_;
		}
		set
		{
			cFOFOCKJGCG_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AEOEFOILEBP()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AEOEFOILEBP(AEOEFOILEBP other)
		: this()
	{
		dACOKFCBMBI_ = other.dACOKFCBMBI_;
		bGADLDEHIIB_ = other.bGADLDEHIIB_;
		panelId_ = other.panelId_;
		cFOFOCKJGCG_ = other.cFOFOCKJGCG_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AEOEFOILEBP Clone()
	{
		return new AEOEFOILEBP(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as AEOEFOILEBP);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(AEOEFOILEBP other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (DACOKFCBMBI != other.DACOKFCBMBI)
		{
			return false;
		}
		if (BGADLDEHIIB != other.BGADLDEHIIB)
		{
			return false;
		}
		if (PanelId != other.PanelId)
		{
			return false;
		}
		if (CFOFOCKJGCG != other.CFOFOCKJGCG)
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
		if (DACOKFCBMBI != 0)
		{
			num ^= DACOKFCBMBI.GetHashCode();
		}
		if (BGADLDEHIIB != 0)
		{
			num ^= BGADLDEHIIB.GetHashCode();
		}
		if (PanelId != 0)
		{
			num ^= PanelId.GetHashCode();
		}
		if (CFOFOCKJGCG != 0)
		{
			num ^= CFOFOCKJGCG.GetHashCode();
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
		if (DACOKFCBMBI != 0)
		{
			output.WriteRawTag(8);
			output.WriteUInt32(DACOKFCBMBI);
		}
		if (BGADLDEHIIB != 0)
		{
			output.WriteRawTag(48);
			output.WriteUInt32(BGADLDEHIIB);
		}
		if (PanelId != 0)
		{
			output.WriteRawTag(64);
			output.WriteUInt32(PanelId);
		}
		if (CFOFOCKJGCG != 0)
		{
			output.WriteRawTag(96);
			output.WriteUInt32(CFOFOCKJGCG);
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
		if (DACOKFCBMBI != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(DACOKFCBMBI);
		}
		if (BGADLDEHIIB != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(BGADLDEHIIB);
		}
		if (PanelId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(PanelId);
		}
		if (CFOFOCKJGCG != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(CFOFOCKJGCG);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(AEOEFOILEBP other)
	{
		if (other != null)
		{
			if (other.DACOKFCBMBI != 0)
			{
				DACOKFCBMBI = other.DACOKFCBMBI;
			}
			if (other.BGADLDEHIIB != 0)
			{
				BGADLDEHIIB = other.BGADLDEHIIB;
			}
			if (other.PanelId != 0)
			{
				PanelId = other.PanelId;
			}
			if (other.CFOFOCKJGCG != 0)
			{
				CFOFOCKJGCG = other.CFOFOCKJGCG;
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
			case 8u:
				DACOKFCBMBI = input.ReadUInt32();
				break;
			case 48u:
				BGADLDEHIIB = input.ReadUInt32();
				break;
			case 64u:
				PanelId = input.ReadUInt32();
				break;
			case 96u:
				CFOFOCKJGCG = input.ReadUInt32();
				break;
			}
		}
	}
}
