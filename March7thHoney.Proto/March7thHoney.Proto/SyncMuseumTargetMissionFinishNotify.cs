using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class SyncMuseumTargetMissionFinishNotify : IMessage<SyncMuseumTargetMissionFinishNotify>, IMessage, IEquatable<SyncMuseumTargetMissionFinishNotify>, IDeepCloneable<SyncMuseumTargetMissionFinishNotify>, IBufferMessage
{
	private static readonly MessageParser<SyncMuseumTargetMissionFinishNotify> _parser = new MessageParser<SyncMuseumTargetMissionFinishNotify>(() => new SyncMuseumTargetMissionFinishNotify());

	private UnknownFieldSet _unknownFields;

	public const int EPOGEOIILNIFieldNumber = 3;

	private bool ePOGEOIILNI_;

	public const int LPAGKHGCCFHFieldNumber = 6;

	private uint lPAGKHGCCFH_;

	public const int EGEFHCFJICCFieldNumber = 13;

	private static readonly FieldCodec<uint> _repeated_eGEFHCFJICC_codec = FieldCodec.ForUInt32(106u);

	private readonly RepeatedField<uint> eGEFHCFJICC_ = new RepeatedField<uint>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<SyncMuseumTargetMissionFinishNotify> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => SyncMuseumTargetMissionFinishNotifyReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool EPOGEOIILNI
	{
		get
		{
			return ePOGEOIILNI_;
		}
		set
		{
			ePOGEOIILNI_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint LPAGKHGCCFH
	{
		get
		{
			return lPAGKHGCCFH_;
		}
		set
		{
			lPAGKHGCCFH_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> EGEFHCFJICC => eGEFHCFJICC_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SyncMuseumTargetMissionFinishNotify()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SyncMuseumTargetMissionFinishNotify(SyncMuseumTargetMissionFinishNotify other)
		: this()
	{
		ePOGEOIILNI_ = other.ePOGEOIILNI_;
		lPAGKHGCCFH_ = other.lPAGKHGCCFH_;
		eGEFHCFJICC_ = other.eGEFHCFJICC_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SyncMuseumTargetMissionFinishNotify Clone()
	{
		return new SyncMuseumTargetMissionFinishNotify(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as SyncMuseumTargetMissionFinishNotify);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(SyncMuseumTargetMissionFinishNotify other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (EPOGEOIILNI != other.EPOGEOIILNI)
		{
			return false;
		}
		if (LPAGKHGCCFH != other.LPAGKHGCCFH)
		{
			return false;
		}
		if (!eGEFHCFJICC_.Equals(other.eGEFHCFJICC_))
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
		if (EPOGEOIILNI)
		{
			num ^= EPOGEOIILNI.GetHashCode();
		}
		if (LPAGKHGCCFH != 0)
		{
			num ^= LPAGKHGCCFH.GetHashCode();
		}
		num ^= eGEFHCFJICC_.GetHashCode();
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
		if (EPOGEOIILNI)
		{
			output.WriteRawTag(24);
			output.WriteBool(EPOGEOIILNI);
		}
		if (LPAGKHGCCFH != 0)
		{
			output.WriteRawTag(48);
			output.WriteUInt32(LPAGKHGCCFH);
		}
		eGEFHCFJICC_.WriteTo(ref output, _repeated_eGEFHCFJICC_codec);
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
		if (EPOGEOIILNI)
		{
			num += 2;
		}
		if (LPAGKHGCCFH != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(LPAGKHGCCFH);
		}
		num += eGEFHCFJICC_.CalculateSize(_repeated_eGEFHCFJICC_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(SyncMuseumTargetMissionFinishNotify other)
	{
		if (other != null)
		{
			if (other.EPOGEOIILNI)
			{
				EPOGEOIILNI = other.EPOGEOIILNI;
			}
			if (other.LPAGKHGCCFH != 0)
			{
				LPAGKHGCCFH = other.LPAGKHGCCFH;
			}
			eGEFHCFJICC_.Add(other.eGEFHCFJICC_);
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
			case 24u:
				EPOGEOIILNI = input.ReadBool();
				break;
			case 48u:
				LPAGKHGCCFH = input.ReadUInt32();
				break;
			case 104u:
			case 106u:
				eGEFHCFJICC_.AddEntriesFrom(ref input, _repeated_eGEFHCFJICC_codec);
				break;
			}
		}
	}
}
