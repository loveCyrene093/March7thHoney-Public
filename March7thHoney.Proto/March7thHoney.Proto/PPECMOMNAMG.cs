using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class PPECMOMNAMG : IMessage<PPECMOMNAMG>, IMessage, IEquatable<PPECMOMNAMG>, IDeepCloneable<PPECMOMNAMG>, IBufferMessage
{
	private static readonly MessageParser<PPECMOMNAMG> _parser = new MessageParser<PPECMOMNAMG>(() => new PPECMOMNAMG());

	private UnknownFieldSet _unknownFields;

	public const int AIIFFJAEODJFieldNumber = 7;

	private AreaDynamicInfo aIIFFJAEODJ_;

	public const int AreaIdFieldNumber = 10;

	private uint areaId_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<PPECMOMNAMG> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => PPECMOMNAMGReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AreaDynamicInfo AIIFFJAEODJ
	{
		get
		{
			return aIIFFJAEODJ_;
		}
		set
		{
			aIIFFJAEODJ_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint AreaId
	{
		get
		{
			return areaId_;
		}
		set
		{
			areaId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PPECMOMNAMG()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PPECMOMNAMG(PPECMOMNAMG other)
		: this()
	{
		aIIFFJAEODJ_ = ((other.aIIFFJAEODJ_ != null) ? other.aIIFFJAEODJ_.Clone() : null);
		areaId_ = other.areaId_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PPECMOMNAMG Clone()
	{
		return new PPECMOMNAMG(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as PPECMOMNAMG);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(PPECMOMNAMG other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(AIIFFJAEODJ, other.AIIFFJAEODJ))
		{
			return false;
		}
		if (AreaId != other.AreaId)
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
		if (aIIFFJAEODJ_ != null)
		{
			num ^= AIIFFJAEODJ.GetHashCode();
		}
		if (AreaId != 0)
		{
			num ^= AreaId.GetHashCode();
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
		if (aIIFFJAEODJ_ != null)
		{
			output.WriteRawTag(58);
			output.WriteMessage(AIIFFJAEODJ);
		}
		if (AreaId != 0)
		{
			output.WriteRawTag(80);
			output.WriteUInt32(AreaId);
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
		if (aIIFFJAEODJ_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(AIIFFJAEODJ);
		}
		if (AreaId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(AreaId);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(PPECMOMNAMG other)
	{
		if (other == null)
		{
			return;
		}
		if (other.aIIFFJAEODJ_ != null)
		{
			if (aIIFFJAEODJ_ == null)
			{
				AIIFFJAEODJ = new AreaDynamicInfo();
			}
			AIIFFJAEODJ.MergeFrom(other.AIIFFJAEODJ);
		}
		if (other.AreaId != 0)
		{
			AreaId = other.AreaId;
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
			case 58u:
				if (aIIFFJAEODJ_ == null)
				{
					AIIFFJAEODJ = new AreaDynamicInfo();
				}
				input.ReadMessage(AIIFFJAEODJ);
				break;
			case 80u:
				AreaId = input.ReadUInt32();
				break;
			}
		}
	}
}
