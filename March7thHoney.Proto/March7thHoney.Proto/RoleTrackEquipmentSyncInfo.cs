using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class RoleTrackEquipmentSyncInfo : IMessage<RoleTrackEquipmentSyncInfo>, IMessage, IEquatable<RoleTrackEquipmentSyncInfo>, IDeepCloneable<RoleTrackEquipmentSyncInfo>, IBufferMessage
{
	private static readonly MessageParser<RoleTrackEquipmentSyncInfo> _parser = new MessageParser<RoleTrackEquipmentSyncInfo>(() => new RoleTrackEquipmentSyncInfo());

	private UnknownFieldSet _unknownFields;

	public const int RoleTrackEquipmentListFieldNumber = 4;

	private static readonly FieldCodec<RoleTrackEquipmentInfo> _repeated_roleTrackEquipmentList_codec = FieldCodec.ForMessage(34u, RoleTrackEquipmentInfo.Parser);

	private readonly RepeatedField<RoleTrackEquipmentInfo> roleTrackEquipmentList_ = new RepeatedField<RoleTrackEquipmentInfo>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<RoleTrackEquipmentSyncInfo> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => RoleTrackEquipmentSyncInfoReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<RoleTrackEquipmentInfo> RoleTrackEquipmentList => roleTrackEquipmentList_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RoleTrackEquipmentSyncInfo()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RoleTrackEquipmentSyncInfo(RoleTrackEquipmentSyncInfo other)
		: this()
	{
		roleTrackEquipmentList_ = other.roleTrackEquipmentList_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RoleTrackEquipmentSyncInfo Clone()
	{
		return new RoleTrackEquipmentSyncInfo(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as RoleTrackEquipmentSyncInfo);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(RoleTrackEquipmentSyncInfo other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!roleTrackEquipmentList_.Equals(other.roleTrackEquipmentList_))
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
		num ^= roleTrackEquipmentList_.GetHashCode();
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
		roleTrackEquipmentList_.WriteTo(ref output, _repeated_roleTrackEquipmentList_codec);
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
		num += roleTrackEquipmentList_.CalculateSize(_repeated_roleTrackEquipmentList_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(RoleTrackEquipmentSyncInfo other)
	{
		if (other != null)
		{
			roleTrackEquipmentList_.Add(other.roleTrackEquipmentList_);
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
			if (num != 34)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
			}
			else
			{
				roleTrackEquipmentList_.AddEntriesFrom(ref input, _repeated_roleTrackEquipmentList_codec);
			}
		}
	}
}
