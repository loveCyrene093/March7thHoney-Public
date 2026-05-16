using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class Dispatch : IMessage<Dispatch>, IMessage, IEquatable<Dispatch>, IDeepCloneable<Dispatch>, IBufferMessage
{
	private static readonly MessageParser<Dispatch> _parser = new MessageParser<Dispatch>(() => new Dispatch());

	private UnknownFieldSet _unknownFields;

	public const int RetcodeFieldNumber = 1;

	private uint retcode_;

	public const int MsgFieldNumber = 2;

	private string msg_ = "";

	public const int TopSeverRegionNameFieldNumber = 3;

	private string topSeverRegionName_ = "";

	public const int RegionListFieldNumber = 4;

	private static readonly FieldCodec<RegionInfo> _repeated_regionList_codec = FieldCodec.ForMessage(34u, RegionInfo.Parser);

	private readonly RepeatedField<RegionInfo> regionList_ = new RepeatedField<RegionInfo>();

	public const int FKCEHMPIAGGFieldNumber = 5;

	private string fKCEHMPIAGG_ = "";

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<Dispatch> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => DispatchReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint Retcode
	{
		get
		{
			return retcode_;
		}
		set
		{
			retcode_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string Msg
	{
		get
		{
			return msg_;
		}
		set
		{
			msg_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string TopSeverRegionName
	{
		get
		{
			return topSeverRegionName_;
		}
		set
		{
			topSeverRegionName_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<RegionInfo> RegionList => regionList_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string FKCEHMPIAGG
	{
		get
		{
			return fKCEHMPIAGG_;
		}
		set
		{
			fKCEHMPIAGG_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public Dispatch()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public Dispatch(Dispatch other)
		: this()
	{
		retcode_ = other.retcode_;
		msg_ = other.msg_;
		topSeverRegionName_ = other.topSeverRegionName_;
		regionList_ = other.regionList_.Clone();
		fKCEHMPIAGG_ = other.fKCEHMPIAGG_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public Dispatch Clone()
	{
		return new Dispatch(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as Dispatch);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(Dispatch other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (Retcode != other.Retcode)
		{
			return false;
		}
		if (Msg != other.Msg)
		{
			return false;
		}
		if (TopSeverRegionName != other.TopSeverRegionName)
		{
			return false;
		}
		if (!regionList_.Equals(other.regionList_))
		{
			return false;
		}
		if (FKCEHMPIAGG != other.FKCEHMPIAGG)
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
		if (Retcode != 0)
		{
			num ^= Retcode.GetHashCode();
		}
		if (Msg.Length != 0)
		{
			num ^= Msg.GetHashCode();
		}
		if (TopSeverRegionName.Length != 0)
		{
			num ^= TopSeverRegionName.GetHashCode();
		}
		num ^= regionList_.GetHashCode();
		if (FKCEHMPIAGG.Length != 0)
		{
			num ^= FKCEHMPIAGG.GetHashCode();
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
		if (Retcode != 0)
		{
			output.WriteRawTag(8);
			output.WriteUInt32(Retcode);
		}
		if (Msg.Length != 0)
		{
			output.WriteRawTag(18);
			output.WriteString(Msg);
		}
		if (TopSeverRegionName.Length != 0)
		{
			output.WriteRawTag(26);
			output.WriteString(TopSeverRegionName);
		}
		regionList_.WriteTo(ref output, _repeated_regionList_codec);
		if (FKCEHMPIAGG.Length != 0)
		{
			output.WriteRawTag(42);
			output.WriteString(FKCEHMPIAGG);
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
		if (Retcode != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Retcode);
		}
		if (Msg.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(Msg);
		}
		if (TopSeverRegionName.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(TopSeverRegionName);
		}
		num += regionList_.CalculateSize(_repeated_regionList_codec);
		if (FKCEHMPIAGG.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(FKCEHMPIAGG);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(Dispatch other)
	{
		if (other != null)
		{
			if (other.Retcode != 0)
			{
				Retcode = other.Retcode;
			}
			if (other.Msg.Length != 0)
			{
				Msg = other.Msg;
			}
			if (other.TopSeverRegionName.Length != 0)
			{
				TopSeverRegionName = other.TopSeverRegionName;
			}
			regionList_.Add(other.regionList_);
			if (other.FKCEHMPIAGG.Length != 0)
			{
				FKCEHMPIAGG = other.FKCEHMPIAGG;
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
				Retcode = input.ReadUInt32();
				break;
			case 18u:
				Msg = input.ReadString();
				break;
			case 26u:
				TopSeverRegionName = input.ReadString();
				break;
			case 34u:
				regionList_.AddEntriesFrom(ref input, _repeated_regionList_codec);
				break;
			case 42u:
				FKCEHMPIAGG = input.ReadString();
				break;
			}
		}
	}
}
