using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class GridFightHandBookPortalInfo : IMessage<GridFightHandBookPortalInfo>, IMessage, IEquatable<GridFightHandBookPortalInfo>, IDeepCloneable<GridFightHandBookPortalInfo>, IBufferMessage
{
	private static readonly MessageParser<GridFightHandBookPortalInfo> _parser = new MessageParser<GridFightHandBookPortalInfo>(() => new GridFightHandBookPortalInfo());

	private UnknownFieldSet _unknownFields;

	public const int GridFightPortalBuffListFieldNumber = 2;

	private static readonly FieldCodec<uint> _repeated_gridFightPortalBuffList_codec = FieldCodec.ForUInt32(18u);

	private readonly RepeatedField<uint> gridFightPortalBuffList_ = new RepeatedField<uint>();

	public const int PELJLONLDNMFieldNumber = 12;

	private static readonly FieldCodec<uint> _repeated_pELJLONLDNM_codec = FieldCodec.ForUInt32(98u);

	private readonly RepeatedField<uint> pELJLONLDNM_ = new RepeatedField<uint>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<GridFightHandBookPortalInfo> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => GridFightHandBookPortalInfoReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> GridFightPortalBuffList => gridFightPortalBuffList_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> PELJLONLDNM => pELJLONLDNM_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GridFightHandBookPortalInfo()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GridFightHandBookPortalInfo(GridFightHandBookPortalInfo other)
		: this()
	{
		gridFightPortalBuffList_ = other.gridFightPortalBuffList_.Clone();
		pELJLONLDNM_ = other.pELJLONLDNM_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GridFightHandBookPortalInfo Clone()
	{
		return new GridFightHandBookPortalInfo(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as GridFightHandBookPortalInfo);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(GridFightHandBookPortalInfo other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!gridFightPortalBuffList_.Equals(other.gridFightPortalBuffList_))
		{
			return false;
		}
		if (!pELJLONLDNM_.Equals(other.pELJLONLDNM_))
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
		num ^= gridFightPortalBuffList_.GetHashCode();
		num ^= pELJLONLDNM_.GetHashCode();
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
		gridFightPortalBuffList_.WriteTo(ref output, _repeated_gridFightPortalBuffList_codec);
		pELJLONLDNM_.WriteTo(ref output, _repeated_pELJLONLDNM_codec);
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
		num += gridFightPortalBuffList_.CalculateSize(_repeated_gridFightPortalBuffList_codec);
		num += pELJLONLDNM_.CalculateSize(_repeated_pELJLONLDNM_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(GridFightHandBookPortalInfo other)
	{
		if (other != null)
		{
			gridFightPortalBuffList_.Add(other.gridFightPortalBuffList_);
			pELJLONLDNM_.Add(other.pELJLONLDNM_);
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
			case 18u:
				gridFightPortalBuffList_.AddEntriesFrom(ref input, _repeated_gridFightPortalBuffList_codec);
				break;
			case 96u:
			case 98u:
				pELJLONLDNM_.AddEntriesFrom(ref input, _repeated_pELJLONLDNM_codec);
				break;
			}
		}
	}
}
