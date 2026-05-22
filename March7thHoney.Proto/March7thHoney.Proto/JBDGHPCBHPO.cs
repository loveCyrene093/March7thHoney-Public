using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class JBDGHPCBHPO : IMessage<JBDGHPCBHPO>, IMessage, IEquatable<JBDGHPCBHPO>, IDeepCloneable<JBDGHPCBHPO>, IBufferMessage
{
	private static readonly MessageParser<JBDGHPCBHPO> _parser = new MessageParser<JBDGHPCBHPO>(() => new JBDGHPCBHPO());

	private UnknownFieldSet _unknownFields;

	public const int HFDMBEHGCMNFieldNumber = 1;

	private static readonly FieldCodec<DADHPAFJDAG> _repeated_hFDMBEHGCMN_codec = FieldCodec.ForMessage(10u, DADHPAFJDAG.Parser);

	private readonly RepeatedField<DADHPAFJDAG> hFDMBEHGCMN_ = new RepeatedField<DADHPAFJDAG>();

	public const int GroupIdFieldNumber = 7;

	private uint groupId_;

	public const int FGCAIKANDMHFieldNumber = 11;

	private bool fGCAIKANDMH_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<JBDGHPCBHPO> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => JBDGHPCBHPOReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<DADHPAFJDAG> HFDMBEHGCMN => hFDMBEHGCMN_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint GroupId
	{
		get
		{
			return groupId_;
		}
		set
		{
			groupId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool FGCAIKANDMH
	{
		get
		{
			return fGCAIKANDMH_;
		}
		set
		{
			fGCAIKANDMH_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public JBDGHPCBHPO()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public JBDGHPCBHPO(JBDGHPCBHPO other)
		: this()
	{
		hFDMBEHGCMN_ = other.hFDMBEHGCMN_.Clone();
		groupId_ = other.groupId_;
		fGCAIKANDMH_ = other.fGCAIKANDMH_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public JBDGHPCBHPO Clone()
	{
		return new JBDGHPCBHPO(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as JBDGHPCBHPO);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(JBDGHPCBHPO other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!hFDMBEHGCMN_.Equals(other.hFDMBEHGCMN_))
		{
			return false;
		}
		if (GroupId != other.GroupId)
		{
			return false;
		}
		if (FGCAIKANDMH != other.FGCAIKANDMH)
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
		num ^= hFDMBEHGCMN_.GetHashCode();
		if (GroupId != 0)
		{
			num ^= GroupId.GetHashCode();
		}
		if (FGCAIKANDMH)
		{
			num ^= FGCAIKANDMH.GetHashCode();
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
		hFDMBEHGCMN_.WriteTo(ref output, _repeated_hFDMBEHGCMN_codec);
		if (GroupId != 0)
		{
			output.WriteRawTag(56);
			output.WriteUInt32(GroupId);
		}
		if (FGCAIKANDMH)
		{
			output.WriteRawTag(88);
			output.WriteBool(FGCAIKANDMH);
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
		num += hFDMBEHGCMN_.CalculateSize(_repeated_hFDMBEHGCMN_codec);
		if (GroupId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(GroupId);
		}
		if (FGCAIKANDMH)
		{
			num += 2;
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(JBDGHPCBHPO other)
	{
		if (other != null)
		{
			hFDMBEHGCMN_.Add(other.hFDMBEHGCMN_);
			if (other.GroupId != 0)
			{
				GroupId = other.GroupId;
			}
			if (other.FGCAIKANDMH)
			{
				FGCAIKANDMH = other.FGCAIKANDMH;
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
			case 10u:
				hFDMBEHGCMN_.AddEntriesFrom(ref input, _repeated_hFDMBEHGCMN_codec);
				break;
			case 56u:
				GroupId = input.ReadUInt32();
				break;
			case 88u:
				FGCAIKANDMH = input.ReadBool();
				break;
			}
		}
	}
}
