using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class GridFightGamePortalBuffInfo : IMessage<GridFightGamePortalBuffInfo>, IMessage, IEquatable<GridFightGamePortalBuffInfo>, IDeepCloneable<GridFightGamePortalBuffInfo>, IBufferMessage
{
	private static readonly MessageParser<GridFightGamePortalBuffInfo> _parser = new MessageParser<GridFightGamePortalBuffInfo>(() => new GridFightGamePortalBuffInfo());

	private UnknownFieldSet _unknownFields;

	public const int PortalBuffIdFieldNumber = 7;

	private uint portalBuffId_;

	public const int PEOFPPOFIGIFieldNumber = 9;

	private static readonly FieldCodec<uint> _repeated_pEOFPPOFIGI_codec = FieldCodec.ForUInt32(74u);

	private readonly RepeatedField<uint> pEOFPPOFIGI_ = new RepeatedField<uint>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<GridFightGamePortalBuffInfo> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => GridFightGamePortalBuffInfoReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint PortalBuffId
	{
		get
		{
			return portalBuffId_;
		}
		set
		{
			portalBuffId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> PEOFPPOFIGI => pEOFPPOFIGI_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GridFightGamePortalBuffInfo()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GridFightGamePortalBuffInfo(GridFightGamePortalBuffInfo other)
		: this()
	{
		portalBuffId_ = other.portalBuffId_;
		pEOFPPOFIGI_ = other.pEOFPPOFIGI_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GridFightGamePortalBuffInfo Clone()
	{
		return new GridFightGamePortalBuffInfo(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as GridFightGamePortalBuffInfo);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(GridFightGamePortalBuffInfo other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (PortalBuffId != other.PortalBuffId)
		{
			return false;
		}
		if (!pEOFPPOFIGI_.Equals(other.pEOFPPOFIGI_))
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
		if (PortalBuffId != 0)
		{
			num ^= PortalBuffId.GetHashCode();
		}
		num ^= pEOFPPOFIGI_.GetHashCode();
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
		if (PortalBuffId != 0)
		{
			output.WriteRawTag(56);
			output.WriteUInt32(PortalBuffId);
		}
		pEOFPPOFIGI_.WriteTo(ref output, _repeated_pEOFPPOFIGI_codec);
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
		if (PortalBuffId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(PortalBuffId);
		}
		num += pEOFPPOFIGI_.CalculateSize(_repeated_pEOFPPOFIGI_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(GridFightGamePortalBuffInfo other)
	{
		if (other != null)
		{
			if (other.PortalBuffId != 0)
			{
				PortalBuffId = other.PortalBuffId;
			}
			pEOFPPOFIGI_.Add(other.pEOFPPOFIGI_);
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
			case 56u:
				PortalBuffId = input.ReadUInt32();
				break;
			case 72u:
			case 74u:
				pEOFPPOFIGI_.AddEntriesFrom(ref input, _repeated_pEOFPPOFIGI_codec);
				break;
			}
		}
	}
}
