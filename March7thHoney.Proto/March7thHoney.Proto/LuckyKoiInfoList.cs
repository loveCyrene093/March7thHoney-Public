using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class LuckyKoiInfoList : IMessage<LuckyKoiInfoList>, IMessage, IEquatable<LuckyKoiInfoList>, IDeepCloneable<LuckyKoiInfoList>, IBufferMessage
{
	private static readonly MessageParser<LuckyKoiInfoList> _parser = new MessageParser<LuckyKoiInfoList>(() => new LuckyKoiInfoList());

	private UnknownFieldSet _unknownFields;

	public const int HeadIconFieldNumber = 2;

	private uint headIcon_;

	public const int IKDCFENDDOBFieldNumber = 3;

	private string iKDCFENDDOB_ = "";

	public const int PNFFLCLMFLOFieldNumber = 15;

	private string pNFFLCLMFLO_ = "";

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<LuckyKoiInfoList> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => LuckyKoiInfoListReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint HeadIcon
	{
		get
		{
			return headIcon_;
		}
		set
		{
			headIcon_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string IKDCFENDDOB
	{
		get
		{
			return iKDCFENDDOB_;
		}
		set
		{
			iKDCFENDDOB_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string PNFFLCLMFLO
	{
		get
		{
			return pNFFLCLMFLO_;
		}
		set
		{
			pNFFLCLMFLO_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public LuckyKoiInfoList()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public LuckyKoiInfoList(LuckyKoiInfoList other)
		: this()
	{
		headIcon_ = other.headIcon_;
		iKDCFENDDOB_ = other.iKDCFENDDOB_;
		pNFFLCLMFLO_ = other.pNFFLCLMFLO_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public LuckyKoiInfoList Clone()
	{
		return new LuckyKoiInfoList(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as LuckyKoiInfoList);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(LuckyKoiInfoList other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (HeadIcon != other.HeadIcon)
		{
			return false;
		}
		if (IKDCFENDDOB != other.IKDCFENDDOB)
		{
			return false;
		}
		if (PNFFLCLMFLO != other.PNFFLCLMFLO)
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
		if (HeadIcon != 0)
		{
			num ^= HeadIcon.GetHashCode();
		}
		if (IKDCFENDDOB.Length != 0)
		{
			num ^= IKDCFENDDOB.GetHashCode();
		}
		if (PNFFLCLMFLO.Length != 0)
		{
			num ^= PNFFLCLMFLO.GetHashCode();
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
		if (HeadIcon != 0)
		{
			output.WriteRawTag(16);
			output.WriteUInt32(HeadIcon);
		}
		if (IKDCFENDDOB.Length != 0)
		{
			output.WriteRawTag(26);
			output.WriteString(IKDCFENDDOB);
		}
		if (PNFFLCLMFLO.Length != 0)
		{
			output.WriteRawTag(122);
			output.WriteString(PNFFLCLMFLO);
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
		if (HeadIcon != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(HeadIcon);
		}
		if (IKDCFENDDOB.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(IKDCFENDDOB);
		}
		if (PNFFLCLMFLO.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(PNFFLCLMFLO);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(LuckyKoiInfoList other)
	{
		if (other != null)
		{
			if (other.HeadIcon != 0)
			{
				HeadIcon = other.HeadIcon;
			}
			if (other.IKDCFENDDOB.Length != 0)
			{
				IKDCFENDDOB = other.IKDCFENDDOB;
			}
			if (other.PNFFLCLMFLO.Length != 0)
			{
				PNFFLCLMFLO = other.PNFFLCLMFLO;
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
				HeadIcon = input.ReadUInt32();
				break;
			case 26u:
				IKDCFENDDOB = input.ReadString();
				break;
			case 122u:
				PNFFLCLMFLO = input.ReadString();
				break;
			}
		}
	}
}
